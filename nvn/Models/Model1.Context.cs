﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace nvn.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class quanlybanhangEntities : DbContext
    {
        public quanlybanhangEntities()
            : base("name=quanlybanhangEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Don_Hang> Don_Hang { get; set; }
        public virtual DbSet<khach_hang> khach_hang { get; set; }
        public virtual DbSet<quan_tri> quan_tri { get; set; }
        public virtual DbSet<San_Pham> San_Pham { get; set; }
        public virtual DbSet<Danhmuc_SP> Danhmuc_SP { get; set; }
    }
}
