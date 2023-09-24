<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVendedores.aspx.cs" Inherits="Casatoro.WebForms.Pages.ListaVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h1>Listado de Vendedores</h1>
    <asp:GridView ID="GVListaVendedores" CssClass="table table-group-divider" AutoGenerateColumns="False" runat="server">
        
        <Columns>
            <asp:BoundField DataField="NombreVendedor" HeaderText="Vendedor"/>
            <asp:BoundField DataField="CedulaVendedor" HeaderText="Cedula"/>
    
     
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton CommandArgument='<%#Eval("Id") %>'
                                    ID="EditarVendedor"
                                    OnClick="EditarVendedor_OnClick"
                                    CssClass="btn btn-primary" 
                                    runat="server">Editar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>

    </asp:GridView>

</asp:Content>
