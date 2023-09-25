﻿//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Casatoro.Datalayer.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Objects;
    using System.Data.Objects.DataClasses;
    using System.Linq;
    
    public partial class CasatoroDBEntities : DbContext
    {
        public CasatoroDBEntities()
            : base("name=CasatoroDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public DbSet<Marcas> Marcas { get; set; }
        public DbSet<Vehiculos> Vehiculos { get; set; }
        public DbSet<Vendedores> Vendedores { get; set; }
        public DbSet<Ventas> Ventas { get; set; }
        public DbSet<VistaVentas> VistaVentas { get; set; }
    
        [EdmFunction("CasatoroDBEntities", "fn_lista_vendedores")]
        public virtual IQueryable<fn_lista_vendedores_Result> fn_lista_vendedores()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_lista_vendedores_Result>("[CasatoroDBEntities].[fn_lista_vendedores]()");
        }
    
        [EdmFunction("CasatoroDBEntities", "fn_lista_ventas")]
        public virtual IQueryable<fn_lista_ventas_Result> fn_lista_ventas()
        {
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<fn_lista_ventas_Result>("[CasatoroDBEntities].[fn_lista_ventas]()");
        }
    
        public virtual int sp_Crear_Marca(string nombreMarca)
        {
            var nombreMarcaParameter = nombreMarca != null ?
                new ObjectParameter("NombreMarca", nombreMarca) :
                new ObjectParameter("NombreMarca", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Crear_Marca", nombreMarcaParameter);
        }
    
        public virtual int sp_Editar_Vendedor(Nullable<int> idVendedor, string nombreVendedor, string cedulaVendedor)
        {
            var idVendedorParameter = idVendedor.HasValue ?
                new ObjectParameter("IdVendedor", idVendedor) :
                new ObjectParameter("IdVendedor", typeof(int));
    
            var nombreVendedorParameter = nombreVendedor != null ?
                new ObjectParameter("NombreVendedor", nombreVendedor) :
                new ObjectParameter("NombreVendedor", typeof(string));
    
            var cedulaVendedorParameter = cedulaVendedor != null ?
                new ObjectParameter("CedulaVendedor", cedulaVendedor) :
                new ObjectParameter("CedulaVendedor", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Editar_Vendedor", idVendedorParameter, nombreVendedorParameter, cedulaVendedorParameter);
        }
    
        public virtual int sp_Eliminar_Venta(Nullable<int> idVenta)
        {
            var idVentaParameter = idVenta.HasValue ?
                new ObjectParameter("IdVenta", idVenta) :
                new ObjectParameter("IdVenta", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_Eliminar_Venta", idVentaParameter);
        }
    
        public virtual ObjectResult<sp_VehiculosByCedula_Result> sp_VehiculosByCedula(string cedula)
        {
            var cedulaParameter = cedula != null ?
                new ObjectParameter("Cedula", cedula) :
                new ObjectParameter("Cedula", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_VehiculosByCedula_Result>("sp_VehiculosByCedula", cedulaParameter);
        }
    }
}
