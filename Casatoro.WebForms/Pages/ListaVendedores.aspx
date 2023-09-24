<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVendedores.aspx.cs" Inherits="Casatoro.WebForms.Pages.ListaVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <h2>Listado de Vendedores</h2>
    
    <br/>
    <div class="row">
        <div class="col-md-12">
            <asp:Button ID="NuevoVendedor" runat="server" OnClick="NuevoVendedor_OnClick" CssClass="btn btn-sm btn-success" Text="Nuevo Vendedor" />
        </div>
    </div>
    <br/>

    <asp:GridView ID="GVListaVendedores" CssClass="table table-striped" AutoGenerateColumns="False" runat="server">
        
        <Columns>
            <asp:BoundField DataField="NombreVendedor" HeaderText="Vendedor"/>
            <asp:BoundField DataField="CedulaVendedor" HeaderText="Cedula"/>
    
     
            <asp:TemplateField>
                <ItemTemplate>
                    <asp:LinkButton CommandArgument='<%#Eval("Id") %>'
                                    ID="EditarVendedor"
                                    OnClick="EditarVendedor_OnClick"
                                    CssClass="btn btn-sm btn-primary" 
                                    runat="server">Editar</asp:LinkButton>
                </ItemTemplate>
            </asp:TemplateField>

        </Columns>

    </asp:GridView>

</asp:Content>
