<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaProvincias.aspx.cs" Inherits="Lab03.Pages.ListaProvincias" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h1>Lista de provincias</h1>
    <div>
        <a href="CrearProvincia.aspx" class="btn btn-primary">Crear Provincia</a>
    </div>
    <div class="primary-container">

        <asp:GridView ID="GvConsultarProvincias" runat="server" AutoGenerateColumns="false" CssClass="table table-striped">
            <Columns>
                <asp:BoundField DataField="idProvincia" HeaderText="Código Provincia" />
                <asp:BoundField DataField="provincia" HeaderText="Nombre Provincia" />
                <asp:BoundField DataField="fechaCreacion" HeaderText="Fecha de creación" />
                <asp:BoundField DataField="estado" HeaderText="Estado" />

                <asp:TemplateField>
                    <ItemTemplate>
                        <a href="EditarProvincia.aspx?id=<%# Eval("idProvincia") %>">Editar</a>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>

    </div>
</asp:Content>
