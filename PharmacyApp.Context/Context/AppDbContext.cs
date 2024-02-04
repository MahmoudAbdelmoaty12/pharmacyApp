using Microsoft.EntityFrameworkCore;
using pharmacyApp.models.Models;
using PharmacyApp.Context.Configrations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PharmacyApp.Context.Context
{
    public class AppDbContext :DbContext
    {
        public virtual DbSet<ApplicationUser> Users { get; set; }
        public virtual DbSet<Medicincs> Medicincs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProducingCompany> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=(localdb)\\mssqllocaldb;Initial Catalog=PharmacyApp;Integrated Security=True;Encrypt=False");
           // optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigration());
            modelBuilder.ApplyConfiguration(new MedicinesConfigration());
            modelBuilder.ApplyConfiguration(new OrdersConfigration());
            modelBuilder.ApplyConfiguration(new CompanyConfigration());
            //modelBuilder.UseChangeTrackingStrategy(QueryTrackingBehavior.NoTracking);
           // ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            base.OnModelCreating(modelBuilder);
        }




    }
}
