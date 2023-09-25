using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Casatoro.BussinessLayer;
using Casatoro.Datalayer.Models;
using Casatoro.Entities;

namespace Casatoro.WebForms.Pages
{
    public partial class ListadoVentas1 : System.Web.UI.Page
    {
        private VentasBl ventasBl = new VentasBl();
        protected void Page_Load(object sender, EventArgs e)
        {
            var texto = CuadroBuscar.Text;
            ListarVentasFn(texto);
        }

        private void ListarVentasFn(string texto)
        {
            var listaVentasFn = ventasBl.BuscarVentasFn(texto).DataSingle;
            GVListaVentas.DataSource = listaVentasFn;
            GVListaVentas.DataBind();
        }

        protected void BotonBuscar_OnClick(object sender, EventArgs e)
        {
            var respuesta = new ResponseBase<List<fn_lista_ventas_Result>>();

            var texto = CuadroBuscar.Text;

            respuesta = ventasBl.BuscarVentasFn(texto);

            if (respuesta.IsValid)
            {
                var listaVentasEncontradas = respuesta.DataSingle;
                GVListaVentas.DataSource = listaVentasEncontradas;
                GVListaVentas.DataBind();
            }
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