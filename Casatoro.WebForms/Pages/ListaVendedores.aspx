<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListaVendedores.aspx.cs" Inherits="Casatoro.WebForms.Pages.ListaVendedores" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row">
        <div class="col-4">
            <h2>Listado de Vendedores</h2>
        </div>
        <div class="col-3">
            <asp:TextBox ID="CuadroBuscar" runat="server"></asp:TextBox>
            <asp:Button ID="BotonBuscar" OnClick="BotonBuscar_OnClick" CommandArgument="" runat="server" Text="Buscar" />
        </div>
    </div>
    
    <div>
        <asp:Label runat="server" CssClass="text-danger" ID="vendedorEliminado"></asp:Label>
    </div>
    <br/>
    <div class="row">
        <div class="col-md-12">
            <asp:Button ID="NuevoVendedor" runat="server" OnClick="NuevoVendedor_OnClick" CssClass="btn btn-sm btn-success" Text="Nuevo Vendedor" />
        </div>
    </div>
    <br/>
    
    <div class="row">
        <div class="col-7">
            <asp:GridView ID="GVListaVendedores" CssClass="table table-striped" AutoGenerateColumns="False" runat="server">

                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="NombreVendedor" HeaderText="Vendedor" />
                    <asp:BoundField DataField="CedulaVendedor" HeaderText="Cedula" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton CommandArgument='<%#Eval("Id") %>'
                                ID="EditarVendedor"
                                OnClick="EditarVendedor_OnClick"
                                CssClass="btn btn-sm btn-primary"
                                runat="server">Editar</asp:LinkButton>



                            <asp:LinkButton CommandArgument='<%#Eval("Id") %>'
                                ID="EliminarVendedor"
                                OnClick="EliminarVendedor_OnClick"
                                CssClass="btn btn-sm btn-danger"
                                runat="server">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </div>

</asp:Content>
