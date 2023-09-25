using Casatoro.Datalayer.Models;
using Casatoro.Datalayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casatoro.Entities;
using Casatoro.Datalayer;

namespace Casatoro.BussinessLayer
{
    public class VentasBl
    {
        //Variables
        VentasDl ventasDl = new VentasDl();


        //Metodos
        public List<Ventas> ListaVentas()
        {
            var listaVentas = new List<Ventas>();
            listaVentas = ventasDl.ListaVentasRB().Result.DataSingle;
            return listaVentas;
        }

        public ResponseBase<List<fn_lista_ventas_Result>> ListaVentasFn()
        {
            var listaVentasFn = new ResponseBase<List<fn_lista_ventas_Result>>();
            listaVentasFn = ventasDl.ListaVentasFn().Result;
            return listaVentasFn;
        }

        public ResponseBase<List<fn_lista_ventas_Result>> BuscarVentasFn(string texto)
        {
            var objResponse = new ResponseBase<List<fn_lista_ventas_Result>>();
            objResponse = ventasDl.BuscarVentasFn(texto).Result;
            return objResponse;
        }

    }
}
