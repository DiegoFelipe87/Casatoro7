using Casatoro.BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Casatoro.WebForms.Pages
{
    public partial class ListaVendedores : System.Web.UI.Page
    {
        private VendedorBl vendedorBl = new VendedorBl();


        protected void Page_Load(object sender, EventArgs e)
        {
            ListarVendedores();
        }

        private void ListarVendedores()
        {
            var listaVendedores = vendedorBl.ListaVendedores();
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
            Response.Redirect("~/Pages/FormularioVendedor.aspx?idEmpleado=0");
        }
    }
}