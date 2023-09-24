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

        /// <summary>
        /// Metodo para obtener la lista de vendedores
        /// </summary>
        public List<Vendedores> ListaVendedores()
        {
            var listaVendedores = new List<Vendedores>();

            listaVendedores = vendedorDl.ListaVendedoresRB().Result.DataSingle;

            return listaVendedores;
        }

        /// <summary>
        /// Metodo para obtener un vendedor por su Id
        /// </summary>
        /// <param name="idVendedor"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public Vendedores ObtenerVendedorPorId(int idVendedor)
        {
            var vendedor = new Vendedores();

            vendedor = vendedorDl.ObtenerVendedorPorIdRB(idVendedor).Result.DataSingle;

            return vendedor;
        }

        /// <summary>
        /// Metodo para editar un vendedor
        /// </summary>
        /// <param name="vendedor"></param>
        /// <returns></returns>
        public ResponseBase<Vendedores> EditarVendedor(Vendedores vendedor)
        {
            var objResponse = new ResponseBase<Vendedores>();

            objResponse = vendedorDl.EditarVendedorRB(vendedor).Result;

            return objResponse;
        }


        /// <summary>
        /// Metodo para crear un vendedor
        /// </summary>
        /// <param name="nombreVendedor"></param>
        /// <param name="cedulaVendedor"></param>
        /// <returns></returns>
        public ResponseBase<Vendedores> CrearVendedor(string nombreVendedor, string cedulaVendedor)
        {
            var objResponse = new ResponseBase<Vendedores>();

            objResponse = vendedorDl.CrearVendedorRB(nombreVendedor, cedulaVendedor).Result;

            return objResponse;
        }
    }

    
}
