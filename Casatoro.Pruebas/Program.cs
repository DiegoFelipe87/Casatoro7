using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Casatoro.Datalayer;
using Casatoro.Datalayer.Models;
using Casatoro.Entities;

namespace Casatoro.Pruebas
{
    class Program
    {
        static void Main(string[] args)
        {
            VendedorDl vendedorDl = new VendedorDl();

            ////Prueba para el metodo VededorDl.BuscarVentasPorCedula
            //List<sp_VehiculosByCedula_Result> buscarVentasPorCedula = new List<sp_VehiculosByCedula_Result>();
            //buscarVentasPorCedula = vendedorDl.BuscarVentasPorCedula("1072123123");

            ////Prueba para el metodo VendedorDl.CrearVendedor
            //var crearVendedor = vendedorDl.CrearVendedorRB("Juanito Ocho", "888");

            //var mensaje = crearVendedor.Result.Message;
            //var vendedorCreado = crearVendedor.Result.DataSingle;

            ////Prueba para el metodo VendedorDl.ListaVendedores
            //var listaVendedores = vendedorDl.ListaVendedoresRB();
            //var mensaje = listaVendedores.Result.Message;
            //var listado = listaVendedores.Result.DataSingle;

            ////Prueba para metodo ObtenerVendedor
            //var vendedor = vendedorDl.ObtenerVendedorPorId(1);

            ////Prueba metodo EditarVendedor
            //var vendedorEditado = new Vendedores()
            //{
            //    Id = 3,
            //    NombreVendedor = "Felipe Silva",
            //    CedulaVendedor = "112233"
            //};

            //var vendedor = vendedorDl.EditarVendedorRB(vendedorEditado);
            //var mensaje = vendedor.Result.Message;
            //var listado = vendedor.Result.DataSingle;

            //Prueba EliminarVendedor

            var vendedorAEliminar = new Vendedores()
            {
                    Id = 13,
                    NombreVendedor = "Juanito Ocho",
                    CedulaVendedor = "888"
            };

            var vendedorEliminado = vendedorDl.EliminarVendedor(vendedorAEliminar);

            var mensaje = vendedorEliminado.Result.Message;
            var vendedor = vendedorEliminado.Result.DataSingle;


        }
        }
}
