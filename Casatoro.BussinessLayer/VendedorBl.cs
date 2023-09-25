using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casatoro.Datalayer;
using Casatoro.Datalayer.Models;
using Casatoro.Entities;

namespace Casatoro.BussinessLayer
{
    public class VendedorBl
    {
        //Variables 
        VendedorDl vendedorDl = new VendedorDl();

       //Métodos
        public List<Vendedores> ListaVendedores()
        {
            var listaVendedores = new List<Vendedores>();
            listaVendedores = vendedorDl.ListaVendedoresRB().Result.DataSingle;
            return listaVendedores;
        }

        public Vendedores ObtenerVendedorPorId(int idVendedor)
        {
            var vendedor = new Vendedores();
            vendedor = vendedorDl.ObtenerVendedorPorIdRB(idVendedor).Result.DataSingle;
            return vendedor;
        }

        public ResponseBase<Vendedores> EditarVendedor(Vendedores vendedor)
        {
            var objResponse = new ResponseBase<Vendedores>();
            objResponse = vendedorDl.EditarVendedorRB(vendedor).Result;
            return objResponse;
        }

        public ResponseBase<Vendedores> CrearVendedor(string nombreVendedor, string cedulaVendedor)
        {
            var objResponse = new ResponseBase<Vendedores>();
            objResponse = vendedorDl.CrearVendedorRB(nombreVendedor, cedulaVendedor).Result;
            return objResponse;
        }

        public ResponseBase<Vendedores> EliminarVEndedor(int idVendedor)
        {
            var objResponse = new ResponseBase<Vendedores>();
            objResponse = vendedorDl.EliminarVendedorRB(idVendedor).Result;
            return objResponse;
        }
    }

    
}
