<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListadoVentas.aspx.cs" Inherits="Casatoro.WebForms.Pages.ListadoVentas" %>
<asp:Content ID="ListadoVentas" ContentPlaceHolderID="MainContent" runat="server">

    <div class="row">
        <div class="col-9">
            <h2>Vista Ventas</h2>
        </div>
       <%-- <div class="col-3">
            <asp:TextBox ID="CuadroBuscar" runat="server"></asp:TextBox>
            <asp:Button ID="BotonBuscar" OnClick="BotonBuscar_OnClick" CommandArgument="" runat="server" Text="Buscar" />
        </div>--%>
    </div>
    
    <br/>
    
    <div>
        <asp:Label runat="server" CssClass="text-danger" ID="ventaEliminada"></asp:Label>
    </div>
    
    <div class="row">
        <div class="col-12">
            <asp:GridView ID="GVListaVentas" CssClass="table table-striped" AutoGenerateColumns="False" runat="server">

                <Columns>
                    <asp:BoundField DataField="Id" HeaderText="Id" />
                    <asp:BoundField DataField="Venta" HeaderText="Venta" />
                    <asp:BoundField DataField="Comprador" HeaderText="Comprador" />
                    <asp:BoundField DataField="Fecha" HeaderText="Fecha" />
                    <asp:BoundField DataField="Vendedor" HeaderText="Vendedor" />
                    <asp:BoundField DataField="Cedula" HeaderText="Cedula" />
                    <asp:BoundField DataField="Placa" HeaderText="Placa" />
                    <asp:BoundField DataField="Color" HeaderText="Color" />
                    <asp:BoundField DataField="Marca" HeaderText="Marca" />




                    <%--<asp:TemplateField>
                        <ItemTemplate>
                            <asp:LinkButton CommandArgument='<%#Bind("Id") %>'
                                            ID="EditarVendedor"
                                            OnClick=""
                                            CssClass="btn btn-sm btn-primary"
                                            runat="server">Editar</asp:LinkButton>



                            <asp:LinkButton CommandArgument='<%#Bind("Id") %>'
                                            ID="EliminarVendedor"
                                            OnClick=""
                                            CssClass="btn btn-sm btn-danger"
                                            runat="server">Eliminar</asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>--%>
                </Columns>

            </asp:GridView>
        </div>
    </div>
</asp:Content>
