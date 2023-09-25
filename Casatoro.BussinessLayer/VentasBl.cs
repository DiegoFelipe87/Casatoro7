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
            var listaVendedores = new List<Ventas>();
            listaVendedores = ventasDl.ListaVentasRB().Result.DataSingle;
            return listaVendedores;
        }
    }
}
