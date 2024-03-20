<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ResultadoDeEliminarProvincia.aspx.cs" Inherits="Lab03.Pages.ResultadoDeEliminarProvincia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Se ha completado el proceso</h2>

    <div class="alert-success">
        <p>Se ha eliminado una provincia en la base de datos</p>
    </div>

    <div>
        <a href="ListaProvincias.aspx">Regresar</a>
    </div>
</asp:Content>
