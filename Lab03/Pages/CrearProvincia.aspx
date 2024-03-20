<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CrearProvincia.aspx.cs" Inherits="Lab03.Pages.CrearProvincia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>CREAR PROVINCIA</h2>

    <div>

        <div>
            <span>Provincia</span>
            <asp:TextBox ID="TxtNombre" runat="server" CssClass="form-control"></asp:TextBox>
        </div>

        <div>
            <asp:Button ID="BtnCrearProvincia" runat="server"
                Text="GUARDAR" BackColor="Blue"
                ForeColor="White" CssClass="btn btn-primary"
                OnClick="BtnCrearProvincia_Click" />
        </div>

        <div>
            <a href="ListaProvincias.aspx" class="btn btn-secondary">Cancelar</a>
        </div>
    </div>
</asp:Content>
