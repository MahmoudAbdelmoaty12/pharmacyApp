﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using PharmacyApp.Context.Context;

#nullable disable

namespace PharmacyApp.Context.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("pharmacyApp.models.Models.ApplicationUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("Age")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(21);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("pharmacyApp.models.Models.Medicincs", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int>("NumberOfOrder")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,2)")
                        .HasDefaultValue(50m);

                    b.Property<int?>("ProducingCompanyId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasDefaultValue(50);

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("ProducingCompanyId");

                    b.ToTable("Medicincs");
                });

            modelBuilder.Entity("pharmacyApp.models.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AddressUser")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("Phone")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("UserIdId")
                        .HasColumnType("int");

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.Property<int?>("medicinceId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserIdId");

                    b.HasIndex("medicinceId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("pharmacyApp.models.Models.ProducingCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("pharmacyApp.models.Models.Medicincs", b =>
                {
                    b.HasOne("pharmacyApp.models.Models.ProducingCompany", "ProducingCompany")
                        .WithMany("Medicincs")
                        .HasForeignKey("ProducingCompanyId");

                    b.Navigation("ProducingCompany");
                });

            modelBuilder.Entity("pharmacyApp.models.Models.Order", b =>
                {
                    b.HasOne("pharmacyApp.models.Models.ApplicationUser", "UserId")
                        .WithMany("orders")
                        .HasForeignKey("UserIdId");

                    b.HasOne("pharmacyApp.models.Models.Medicincs", "medicince")
                        .WithMany("orders")
                        .HasForeignKey("medicinceId");

                    b.Navigation("UserId");

                    b.Navigation("medicince");
                });

            modelBuilder.Entity("pharmacyApp.models.Models.ApplicationUser", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("pharmacyApp.models.Models.Medicincs", b =>
                {
                    b.Navigation("orders");
                });

            modelBuilder.Entity("pharmacyApp.models.Models.ProducingCompany", b =>
                {
                    b.Navigation("Medicincs");
                });
#pragma warning restore 612, 618
        }
    }
}
