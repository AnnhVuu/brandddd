﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Shop_ReactApp.Server.Models;

#nullable disable

namespace Shop_ReactApp.Server.Migrations
{
    [DbContext(typeof(DataWeb))]
    partial class DataWebModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Accounts", b =>
                {
                    b.Property<string>("IdAccount")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int?>("RoleIdRole")
                        .HasColumnType("int");

                    b.Property<string>("UsersEmail")
                        .IsRequired()
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdAccount");

                    b.HasIndex("RoleIdRole");

                    b.HasIndex("UsersEmail");

                    b.ToTable("Accounts");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Bills", b =>
                {
                    b.Property<string>("IdBill")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("AccountsIdAccount")
                        .HasColumnType("nvarchar(10)");

                    b.Property<bool>("DeliveryStatus")
                        .HasColumnType("bit");

                    b.Property<DateTime>("ExportDate")
                        .HasColumnType("datetime2");

                    b.Property<float>("FullPrice")
                        .HasColumnType("real");

                    b.Property<string>("IdAccount")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("IdBill");

                    b.HasIndex("AccountsIdAccount");

                    b.ToTable("Bills");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Brands", b =>
                {
                    b.Property<string>("IdBrand")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("NameBrand")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Nation")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.HasKey("IdBrand");

                    b.ToTable("Brands");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.DetailsBill", b =>
                {
                    b.Property<string>("IdDetailBill")
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.Property<string>("BillsIdBill")
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("DeliveryAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdDetailBill");

                    b.HasIndex("BillsIdBill");

                    b.ToTable("DetailsBill");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Products", b =>
                {
                    b.Property<string>("IdProduct")
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<string>("DescriptionProduct")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("IDBrands")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdBrand")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<string>("Image")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameProduct")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("PromotionalPrice")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("IdProduct");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Role", b =>
                {
                    b.Property<int>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdRole"));

                    b.Property<string>("RoleName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Users", b =>
                {
                    b.Property<string>("Email")
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<DateTime>("Dateofbirth")
                        .HasColumnType("datetime2");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("nvarchar(250)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("Email");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Accounts", b =>
                {
                    b.HasOne("Shop_ReactApp.Server.Models.Role", null)
                        .WithMany("Accounts")
                        .HasForeignKey("RoleIdRole");

                    b.HasOne("Shop_ReactApp.Server.Models.Users", "Users")
                        .WithMany()
                        .HasForeignKey("UsersEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Users");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Bills", b =>
                {
                    b.HasOne("Shop_ReactApp.Server.Models.Accounts", "Accounts")
                        .WithMany("Bills")
                        .HasForeignKey("AccountsIdAccount");

                    b.Navigation("Accounts");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.DetailsBill", b =>
                {
                    b.HasOne("Shop_ReactApp.Server.Models.Bills", "Bills")
                        .WithMany("DetailsBill")
                        .HasForeignKey("BillsIdBill");

                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Accounts", b =>
                {
                    b.Navigation("Bills");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Bills", b =>
                {
                    b.Navigation("DetailsBill");
                });

            modelBuilder.Entity("Shop_ReactApp.Server.Models.Role", b =>
                {
                    b.Navigation("Accounts");
                });
#pragma warning restore 612, 618
        }
    }
}
