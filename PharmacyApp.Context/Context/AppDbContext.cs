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
<<<<<<< HEAD
        public virtual DbSet<ApplicationUser> Users { get; set; }
        public virtual DbSet<Medicincs> Medicincs { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<ProducingCompany> Companies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source = (localdb)\\mssqllocaldb; Initial Catalog = PharmacyApp; Integrated Security = True; Encrypt = True;encrypt=false");

            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfigration());
            modelBuilder.ApplyConfiguration(new MedicinesConfigration());
            modelBuilder.ApplyConfiguration(new OrdersConfigration());
            modelBuilder.ApplyConfiguration(new CompanyConfigration());

            
            base.OnModelCreating(modelBuilder);
        }
=======




>>>>>>> 7b53128a2e3f45c665b02bb3b45b5e8b6619549e
    }
}
