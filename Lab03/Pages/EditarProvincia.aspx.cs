using Lab03.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab03.Pages
{
    public partial class EditarProvincia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(IsPostBack == false)
            {
                int idProvincia = Convert.ToInt32(Request.QueryString["id"]);
                TxtIDProvincia.Text = idProvincia.ToString();

                try
                {
                    using (P5_Lab03Entities db = new P5_Lab03Entities())
                    {
                        var datos = db.spConsultarProvinciaPorId(idProvincia).FirstOrDefault();
                        if (datos != null)
                        {
                            TxtNombreProvincia.Text = datos.nombre;
                        }
                    }
                }
                catch (Exception)
                {
                    Response.Redirect("Error.aspx");
                }
            }
        }

        protected void BtnModificarProvincia_Click(object sender, EventArgs e)
        {
            try
            {
                int idProvincia = Convert.ToInt32(TxtIDProvincia.Text.Trim());
                string nombre = TxtNombreProvincia.Text.Trim();

                using (P5_Lab03Entities db = new P5_Lab03Entities())
                {
                    db.spEditarProvincia(idProvincia, nombre, "A");
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }
            Response.Redirect("ResultadoDeEditarProvincia.aspx");
        }

        protected void BtnEliminarProvincia_Click(object sender, EventArgs e)
        {
            try
            {
                int idProvincia = Convert.ToInt32(TxtIDProvincia.Text.Trim());

                using (P5_Lab03Entities db = new P5_Lab03Entities())
                {
                    db.spEliminarProvincia(idProvincia);
                }
            }
            catch (Exception)
            {
                Response.Redirect("Error.aspx");
            }
            Response.Redirect("ResultadoDeEliminarProvincia.aspx");
        }
    }
}