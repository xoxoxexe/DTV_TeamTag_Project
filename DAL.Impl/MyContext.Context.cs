﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Der Code wurde von einer Vorlage generiert.
//
//     Manuelle Änderungen an dieser Datei führen möglicherweise zu unerwartetem Verhalten der Anwendung.
//     Manuelle Änderungen an dieser Datei werden überschrieben, wenn der Code neu generiert wird.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DAL.Impl
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class teamtageEntities1 : DbContext
    {
        public teamtageEntities1()
            : base("name=teamtageEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Angebote> Angebote { get; set; }
        public virtual DbSet<Angebotspositionen> Angebotspositionen { get; set; }
        public virtual DbSet<Kunden> Kunden { get; set; }
        public virtual DbSet<Rechnungen> Rechnungen { get; set; }
        public virtual DbSet<Rechnungspositionen> Rechnungspositionen { get; set; }
    }
}
