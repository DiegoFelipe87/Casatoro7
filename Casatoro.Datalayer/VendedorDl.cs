using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Casatoro.Datalayer.Models;
using Casatoro.Entities;


namespace Casatoro.Datalayer
{
    public class VendedorDl
    {
        /// <summary>
        /// Metodo para crear un nuevo vendedor
        /// </summary>
        /// <param name="nombreVendedor"></param>
        /// <param name="cedulaVendedor"></param>
        /// <returns></returns>
        public async Task<ResponseBase<Vendedores>> CrearVendedorRB(string nombreVendedor, string cedulaVendedor)
        {
            var objResponse = new ResponseBase<Vendedores>();
            var vendedorCreado = new Vendedores();

            try
            {
                using (var dbContext = new CasatoroDBEntities())
                {
                    //Verificar que no se repita el número de cédula
                    var anteriorListadoDeVendedores = dbContext.Vendedores.ToList();
                    var listadoCedulasRepetidas = anteriorListadoDeVendedores.Where(x => x.CedulaVendedor == cedulaVendedor).ToList();
                    var cantidadDeCedulasRepetidas = listadoCedulasRepetidas.Count();

                    if (cantidadDeCedulasRepetidas > 0)
                        throw new Exception(Messages.ObservationFieldDuplicated);

                    dbContext.Vendedores.Add(new Vendedores()
                    {
                        NombreVendedor = nombreVendedor,
                        CedulaVendedor = cedulaVendedor
                    });
                    dbContext.SaveChanges();

                    var nuevoListadoVendedores = dbContext.Vendedores.ToList();
                    vendedorCreado = nuevoListadoVendedores.Find(x => x.CedulaVendedor == cedulaVendedor);
                }

                objResponse.DataSingle= vendedorCreado;
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

        
        /// <summary>
        /// Metodo para retornar la lista de todos los vendedores existentes en la BD
        /// </summary>
        /// <returns></returns>
        public async Task<ResponseBase<List<Vendedores>>> ListaVendedoresRB()
        {
            var objResponse = new ResponseBase<List<Vendedores>>();
            var listaVendedores = new List<Vendedores>();

            try
            {
                using (var dbContext = new CasatoroDBEntities())
                {
                    listaVendedores = dbContext.Vendedores.ToList();
                }

                objResponse.DataSingle = listaVendedores;
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


        /// <summary>
        /// Metodo para buscar las ventas de un vendedor ingresando su numero de cedula
        /// </summary>
        /// <param name="cedulaVendedor"></param>
        /// <returns></returns>
        public async Task<ResponseBase<List<sp_VehiculosByCedula_Result>>> BuscarVentasPorCedulaRB(string cedulaVendedor)
        {
            var objResponse = new ResponseBase<List<sp_VehiculosByCedula_Result>>();
            var buscarVentasPorCedula = new List<sp_VehiculosByCedula_Result>();

            try
            {
                using (var dbContext = new CasatoroDBEntities())
                {
                    buscarVentasPorCedula = dbContext.sp_VehiculosByCedula(cedulaVendedor).ToList();
                }

                objResponse.DataSingle = buscarVentasPorCedula;
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


        /// <summary>
        /// Metodo para obtener un vendedor por medio de su Id
        /// </summary>
        /// <param name="idVendedor"></param>
        /// <returns></returns>
        public async Task<ResponseBase<Vendedores>> ObtenerVendedorPorIdRB(int idVendedor)
        {
            var objResponse = new ResponseBase<Vendedores>();
            var vendedorObtenidoPorId = new Vendedores();
            try
            {
                vendedorObtenidoPorId = ListaVendedoresRB().Result.DataSingle.Find(x => x.Id == idVendedor);
                
                objResponse.DataSingle = vendedorObtenidoPorId;
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


        /// <summary>
        /// Metodo para editar un vendedor
        /// </summary>
        /// <param name="vendedorAEditar"></param>
        /// <returns></returns>
        public async Task<ResponseBase<Vendedores>> EditarVendedorRB(Vendedores vendedorAEditar)
        {
            var objResponse = new ResponseBase<Vendedores>();
            var vendedorEditado = new Vendedores();

            try
            {
                using (var dbContext = new CasatoroDBEntities())
                {
                    var vendedorEncontradoPorId = dbContext.Vendedores.Where(x => x.Id == vendedorAEditar.Id);

                    foreach (var v in vendedorEncontradoPorId)
                    {
                        v.NombreVendedor = vendedorAEditar.NombreVendedor;
                        v.CedulaVendedor = vendedorAEditar.CedulaVendedor;
                    }

                    //Verificar que no se repita el número de cédula
                    var nuevoListadoDeVendedores = dbContext.Vendedores.ToList();
                    var listadoCedulasRepetidas = nuevoListadoDeVendedores.Where(x => x.CedulaVendedor == vendedorAEditar.CedulaVendedor).ToList();
                    var cantidadCedulasRepetidas = listadoCedulasRepetidas.Count();

                    if (cantidadCedulasRepetidas > 1)
                        throw new Exception(Messages.ObservationFieldDuplicated);

                    dbContext.SaveChanges();

                    var nuevoListadoVendedores = dbContext.Vendedores.ToList();
                    vendedorEditado = nuevoListadoVendedores.Find(x => x.CedulaVendedor == vendedorAEditar.CedulaVendedor);
                }

                objResponse.DataSingle= vendedorEditado;
                objResponse.IsValid = true;
                objResponse.Message = Messages.ResponseOk;
            }
            catch (Exception ex)
            {
                objResponse.IsValid= false;
                objResponse.Message = Messages.ResponseException + ex.Message;
            }
            
            return objResponse;
        }

        public async Task<ResponseBase<Vendedores>> EliminarVendedor(Vendedores vendedorAEliminar)
        {
            var objResponse = new ResponseBase<Vendedores>();
            var vendedorEliminado = new Vendedores();
            try
            {
                using (var dbContext = new CasatoroDBEntities())
                {
                    var vendedorEncontradoPorId = dbContext.Vendedores.ToList().Find(x => x.Id == vendedorAEliminar.Id);

                    dbContext.Vendedores.Remove(vendedorEncontradoPorId);
                    dbContext.SaveChanges();
                    vendedorEliminado = vendedorEncontradoPorId;
                }

                objResponse.DataSingle = vendedorEliminado;
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
