﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace libCouch2.Modelo
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BD_SHAREIT_PROYECTO_COUCHIN_Var : DbContext
    {
        public BD_SHAREIT_PROYECTO_COUCHIN_Var()
            : base("name=BD_SHAREIT_PROYECTO_COUCHIN_Var")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<DIRECCION> DIRECCIONs { get; set; }
        public virtual DbSet<PERSONA> PERSONAs { get; set; }
        public virtual DbSet<PUBLICACION> PUBLICACIONs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TABLA> TABLAs { get; set; }
        public virtual DbSet<TABLA1> TABLAS1 { get; set; }
        public virtual DbSet<TIPO_HOSPEDAJE> TIPO_HOSPEDAJE { get; set; }
        public virtual DbSet<USUARIO> USUARIOs { get; set; }
        public virtual DbSet<FOTO> FOTOS { get; set; }
    }
}
