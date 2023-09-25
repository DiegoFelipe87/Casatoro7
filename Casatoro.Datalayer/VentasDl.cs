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
    }
}
