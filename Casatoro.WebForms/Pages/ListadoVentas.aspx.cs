using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Casatoro.BussinessLayer;

namespace Casatoro.WebForms.Pages
{
    public partial class ListadoVentas1 : System.Web.UI.Page
    {
        private VentasBl ventasBl = new VentasBl();
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarVentas();
        }

        private void ListarVentas()
        {
            var listaVentas = ventasBl.ListaVentas();
            GVListaVentas.DataSource = listaVentas;
            GVListaVentas.DataBind();
        }

        protected void BotonBuscar_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void EditarVenta_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        protected void EliminarVenta_OnClick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }
    }
}