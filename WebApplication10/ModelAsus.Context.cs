﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebApplication10
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class projectEntities1 : DbContext
    {
        public projectEntities1()
            : base("name=projectEntities1")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Booking_Details> Booking_Details { get; set; }
        public virtual DbSet<Customer_Info> Customer_Info { get; set; }
        public virtual DbSet<Employee_Info> Employee_Info { get; set; }
        public virtual DbSet<Movie_Info> Movie_Info { get; set; }
        public virtual DbSet<Payment_Info> Payment_Info { get; set; }
        public virtual DbSet<Seat_Details> Seat_Details { get; set; }
        public virtual DbSet<Show_Info> Show_Info { get; set; }
        public virtual DbSet<Theater_Info> Theater_Info { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
    }
}