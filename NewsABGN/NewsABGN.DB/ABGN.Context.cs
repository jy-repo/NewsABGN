﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NewsABGN.DB
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ABGNDBEntities : DbContext
    {
        public ABGNDBEntities()
            : base("name=ABGNDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Keyword> Keywords { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<Scrap> Scraps { get; set; }
    }
}
