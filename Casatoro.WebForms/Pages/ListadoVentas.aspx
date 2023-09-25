<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoVentas.aspx.cs" Inherits="Casatoro.WebForms.Pages.ListadoVentas1" %>
<asp:Content ID="ListadoVentas" ContentPlaceHolderID="MainContent" runat="server">
    
    <div class="row">
        <div class="col-4">
            <h2>Listado de Ventas</h2>
        </div>
        <div class="col-3">
            <asp:TextBox ID="CuadroBuscar" runat="server"></asp:TextBox>
            <asp:Button ID="BotonBuscar" OnClick="BotonBuscar_OnClick" CommandArgument="" runat="server" Text="Buscar" />
        </div>
    </div>
    
    <div>
        <asp:Label runat="server" CssClass="text-danger" ID="ventaEliminada"></asp:Label>
    </div>
    <br/>
    
    <asp:LinqDataSource ID="LinqDataSource1" runat="server"></asp:LinqDataSource>

   
    
    <div class="row">
        <div class="col-7">
            <asp:GridView ID="GVListaVentas" CssClass="table table-striped" AutoGenerateColumns="False" runat="server">

                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id Venta" />
                    <asp:BoundField DataField="Vendedor" HeaderText="Vendedor" />
                    <asp:BoundField DataField="Cedula" HeaderText="Cedula" />
                    <asp:BoundField DataField="Venta" HeaderText="Venta" />
                    <asp:BoundField DataField="Comprador" HeaderText="Comprador" />
                    <asp:BoundField DataField="Placa" HeaderText="Placa" />
                    <asp:BoundField DataField="Color" HeaderText="Color" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                    <asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton CommandArgument='<%#Eval("Id") %>'
                                            ID="EditarVenta"
                                            OnClick="EditarVenta_OnClick"
                                            CssClass="btn btn-sm btn-primary"
                                            runat="server">Editar</asp:LinkButton>



                            <asp:LinkButton CommandArgument='<%#Eval("Id") %>'
                                            ID="EliminarVenta"
                                            OnClick="EliminarVenta_OnClick"
                                            CssClass="btn btn-sm btn-danger"
                                            runat="server">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>

            </asp:GridView>
        </div>
    </div>



</asp:Content>
