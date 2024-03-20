using Lab03.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Lab03.Pages
{
    public partial class CrearProvincia : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void BtnCrearProvincia_Click(object sender, EventArgs e)
        {
            string nombre = TxtNombre.Text;
            DateTime fechaCreacion = DateTime.Now;

            try
            {
                using (P5_Lab03Entities db = new P5_Lab03Entities())
                {
                    db.spCrearProvincia(nombre, fechaCreacion);
                }
            }
            catch (Exception)
            {
                Response.Redirect("~/Pages/Error.aspx");
            }

            Response.Redirect("~/Pages/ResultadoDeCrearProvincia.aspx");
        }
    }
}