using Casatoro.BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Casatoro.Datalayer.Models;
using Casatoro.Entities;
using System.Threading;

namespace Casatoro.WebForms.Pages
{
    public partial class ListaVendedores : System.Web.UI.Page
    {
        private VendedorBl vendedorBl = new VendedorBl();


        protected void Page_Load(object sender, EventArgs e)
        {
            var texto = CuadroBuscar.Text;
            ListarVendedores(texto);
        }

        private void ListarVendedores(string texto)
        {
            var listaVendedores = vendedorBl.BuscarVendedor(texto).DataSingle;
            GVListaVendedores.DataSource = listaVendedores;
            GVListaVendedores.DataBind();
        }

        protected void EditarVendedor_OnClick(object sender, EventArgs e)
        {
            LinkButton editarVendedorbtn = (LinkButton)sender;
            string Id = editarVendedorbtn.CommandArgument;
            Response.Redirect($"~/Pages/FormularioVendedor.aspx?id={Id}");
        }

        protected void NuevoVendedor_OnClick(object sender, EventArgs e)
        {
            Response.Redirect("~/Pages/FormularioVendedor.aspx?id=0");
        }

        protected void EliminarVendedor_OnClick(object sender, EventArgs e)
        {
            var respuesta = new ResponseBase<Vendedores>();

            LinkButton eliminarVendedorButton = (LinkButton)sender;
            string Id = eliminarVendedorButton.CommandArgument;

            respuesta = vendedorBl.EliminarVEndedor(Convert.ToInt32(Id));

            if (respuesta.IsValid)
            {
                vendedorEliminado.Text = respuesta.Message + ". Se elimino el vendedor " + respuesta.DataSingle.NombreVendedor;
            }
        }


        protected void BotonBuscar_OnClick(object sender, EventArgs e)
        {

            var respuesta = new ResponseBase<List<Vendedores>>();

            var texto = CuadroBuscar.Text;

            respuesta = vendedorBl.BuscarVendedor(texto);

            if (respuesta.IsValid)
            {
                var listaVendedoresEncontrados = respuesta.DataSingle;
                GVListaVendedores.DataSource = listaVendedoresEncontrados;
                GVListaVendedores.DataBind();
            }




        }
    }
}