using Casatoro.Datalayer.Models;
using Casatoro.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Casatoro.Datalayer
{
    public class VentasDl
    {
        public async Task<ResponseBase<List<Ventas>>> ListaVentasRB()
        {
            var objResponse = new ResponseBase<List<Ventas>>();
            var listaVentas = new List<Ventas>();

            try
            {
                using (var dbContext = new CasatoroDBEntities())
                {
                    listaVentas = dbContext.Ventas.ToList();
                }

                objResponse.DataSingle = listaVentas;
                objResponse.IsValid = true;
                objResponse.Message = Messages.ResponseOk;
            }
            catch (Exception ex)
            {
                objResponse.IsValid = false;
                objResponse.Message = Messages.ResponseException + ex.Message;
            }

            return objResponse;
        }


        public async Task<ResponseBase<List<fn_lista_ventas_Result>>> ListaVentasFn()
        {
            var objResponse = new ResponseBase<List<fn_lista_ventas_Result>>();
            var listaVentasFn = new List<fn_lista_ventas_Result>();
            try
            {
                using (var dbContext = new CasatoroDBEntities())
                {
                    listaVentasFn = dbContext.fn_lista_ventas().ToList();
                }

                objResponse.DataSingle = listaVentasFn;
                objResponse.IsValid = true;
                objResponse.Message = Messages.ResponseOk;
            }
            catch (Exception ex)
            {
                objResponse.IsValid = false;
                objResponse.Message = Messages.ResponseException + ex.Message;
            }

            return objResponse;
        }

        public async Task<ResponseBase<List<fn_lista_ventas_Result>>> BuscarVentasFn(string texto)
        {
            var objResponse = new ResponseBase<List<fn_lista_ventas_Result>>();
            var listaVentasEncontradas = new List<fn_lista_ventas_Result>();

            try
            {
                using (var dbContext = new CasatoroDBEntities())
                {
                    listaVentasEncontradas = dbContext.fn_lista_ventas().ToList().Where(x => x.Vendedor.Contains(texto) || x.Cedula.Contains(texto) || x.Venta.Contains(texto) || x.Comprador.Contains(texto) || x.Placa.Contains(texto) || x.Color.Contains(texto) || x.Fecha.Contains(texto)).ToList();
                }

                objResponse.DataSingle = listaVentasEncontradas;
                objResponse.IsValid = true;
                objResponse.Message = Messages.ResponseOk;
            }
            catch (Exception ex)
            {
                objResponse.IsValid = false;
                objResponse.Message = Messages.ResponseException;
            }

            return objResponse;

        }
    }
}
