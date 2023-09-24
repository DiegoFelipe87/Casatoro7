<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="FormularioVendedor.aspx.cs" Inherits="Casatoro.WebForms.Pages.FormularioVendedor" %>
<asp:Content ID="FormularioVendedor" ContentPlaceHolderID="MainContent" runat="server">
    <br/>
    <div>
        <label class="modal-title">Nombre del Vendedor</label>
        <asp:TextBox ID="txtNombreVendedor" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <br/>
    <div>
        <label class="modal-title">No. de Cedula</label>
        <asp:TextBox ID="txtCedulaVendedor" CssClass="form-control" runat="server"></asp:TextBox>
    </div>
    <br/>
    <asp:Button ID="btnSubmit" runat="server" Text="Enviar" CssClass="btn btn-lg btn-success" OnClick="btnSubmit_OnClick" />
</asp:Content>
