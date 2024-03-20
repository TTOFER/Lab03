<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EditarProvincia.aspx.cs" Inherits="Lab03.Pages.EditarProvincia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Modificar Provincia</h2>

    <div>

        <div>
            <span>ID</span>
            <asp:TextBox ID="TxtIDProvincia" runat="server" CssClass="form-control" Enabled="false"></asp:TextBox>
        </div>

        <div>
            <span>Provincia</span>
            <asp:TextBox ID="TxtNombreProvincia" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="BtnModificarProvincia" runat="server" Text="Modificar" CssClass="btn btn-primary" OnClick="BtnModificarProvincia_Click" />

            <asp:Button ID="BtnEliminarProvincia" runat="server" Text="Eliminar" CssClass="btn-primary" OnClick="BtnEliminarProvincia_Click" />
        </div>

        <div>
            <a href="ListaProvincias.aspx" class="btn btn-primary">Cancelar</a>
        </div>

    </div>
</asp:Content>
