//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DoAn
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class QLDUNGCUEntities : DbContext
    {
        public QLDUNGCUEntities()
            : base("name=QLDUNGCUEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETMUON> CHITIETMUONs { get; set; }
        public virtual DbSet<DUNGCU> DUNGCUs { get; set; }
        public virtual DbSet<GIAOVIEN> GIAOVIENs { get; set; }
        public virtual DbSet<LOP> LOPs { get; set; }
        public virtual DbSet<MUON> MUONs { get; set; }
    }
}
