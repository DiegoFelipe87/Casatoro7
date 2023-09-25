using Casatoro.BussinessLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Casatoro.Datalayer.Models;
using Casatoro.Entities;

namespace Casatoro.WebForms.Pages
{
    public partial class ListadoVentas : System.Web.UI.Page
    {
        private VendedorBl vendedorBl = new VendedorBl();
        protected void Page_Load(object sender, EventArgs e)
        {
            ListarVentas();
        }

        private void ListarVentasPorCedula(string cedula)
        {
            var listaVentasPorCedula = vendedorBl.BuscarVentasPorCedula(cedula).DataSingle;
            GVListaVentas.DataSource = listaVentasPorCedula;
            GVListaVentas.DataBind();
        }

        private void ListarVentas()
        {
            var listaVentas = vendedorBl.ListarVentas().DataSingle;
            GVListaVentas.DataSource = listaVentas;
            GVListaVentas.DataBind();
        }


        //protected void BotonBuscar_OnClick(object sender, EventArgs e)
        //{
        //    var respuesta = new ResponseBase<List<sp_VehiculosByCedula_Result>>();

        //    var cedula = CuadroBuscar.Text;

        //    respuesta = vendedorBl.BuscarVentasPorCedula(cedula);

        //    if (respuesta.IsValid)
        //    {
        //        var listaVentasPorCedula = respuesta.DataSingle;
        //        GVListaVentas.DataSource = listaVentasPorCedula;
        //        GVListaVentas.DataBind();
        //    }
        //}
    }
}