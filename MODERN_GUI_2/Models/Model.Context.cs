﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MODERN_GUI_2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDAPOLOFEEntities : DbContext
    {
        public BDAPOLOFEEntities()
            : base("name=BDAPOLOFEEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<APACCESO> APACCESO { get; set; }
        public virtual DbSet<APCERTIFICADO> APCERTIFICADO { get; set; }
        public virtual DbSet<APCODIGOERROR> APCODIGOERROR { get; set; }
        public virtual DbSet<APCORREO> APCORREO { get; set; }
        public virtual DbSet<APCORREOSOPORTE> APCORREOSOPORTE { get; set; }
        public virtual DbSet<APEMPRESA> APEMPRESA { get; set; }
        public virtual DbSet<APESTADO> APESTADO { get; set; }
        public virtual DbSet<APFACTURACAB> APFACTURACAB { get; set; }
        public virtual DbSet<APFORMAPAGO> APFORMAPAGO { get; set; }
        public virtual DbSet<APOPERADOR> APOPERADOR { get; set; }
        public virtual DbSet<APREGION> APREGION { get; set; }
        public virtual DbSet<APRUTAARCHIVO> APRUTAARCHIVO { get; set; }
        public virtual DbSet<APSCRIPT> APSCRIPT { get; set; }
        public virtual DbSet<APSUCURSAL> APSUCURSAL { get; set; }
        public virtual DbSet<APTIPODOC> APTIPODOC { get; set; }
        public virtual DbSet<APGUIACAB> APGUIACAB { get; set; }
        public virtual DbSet<APNCRCAB> APNCRCAB { get; set; }
        public virtual DbSet<APRETENCION> APRETENCION { get; set; }
    }
}
