//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class Marcas
    {
        public Marcas()
        {
            this.Vehiculos = new HashSet<Vehiculos>();
        }
    
        public int Id { get; set; }
        public string NombreMarca { get; set; }
    
        public virtual ICollection<Vehiculos> Vehiculos { get; set; }
    }
}
