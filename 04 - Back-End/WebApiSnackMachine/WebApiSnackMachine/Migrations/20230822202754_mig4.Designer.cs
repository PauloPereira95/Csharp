﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiSnackMachine.Data;

#nullable disable

namespace WebApiSnackMachine.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230822202754_mig4")]
    partial class mig4
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("IntervectionMachine", b =>
                {
                    b.Property<Guid>("IntervectionIDIntervection")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MachineIDMachine")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IntervectionIDIntervection", "MachineIDMachine");

                    b.HasIndex("MachineIDMachine");

                    b.ToTable("IntervectionMachine");
                });

            modelBuilder.Entity("IntervectionSupport", b =>
                {
                    b.Property<Guid>("IntervectionIDIntervection")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SupportIDSupport")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IntervectionIDIntervection", "SupportIDSupport");

                    b.HasIndex("SupportIDSupport");

                    b.ToTable("IntervectionSupport");
                });

            modelBuilder.Entity("MachinePosition", b =>
                {
                    b.Property<Guid>("MachineIDMachine")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PositionIDPosition")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MachineIDMachine", "PositionIDPosition");

                    b.HasIndex("PositionIDPosition");

                    b.ToTable("MachinePosition");
                });

            modelBuilder.Entity("MachineProduct", b =>
                {
                    b.Property<Guid>("MachineIDMachine")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductIDProduct")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MachineIDMachine", "ProductIDProduct");

                    b.HasIndex("ProductIDProduct");

                    b.ToTable("MachineProduct");
                });

            modelBuilder.Entity("MachineSupport", b =>
                {
                    b.Property<Guid>("MachineIDMachine")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SupportIDSupport")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MachineIDMachine", "SupportIDSupport");

                    b.HasIndex("SupportIDSupport");

                    b.ToTable("MachineSupport");
                });

            modelBuilder.Entity("PositionProduct", b =>
                {
                    b.Property<Guid>("PositionIDPosition")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("ProductIDProduct")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("PositionIDPosition", "ProductIDProduct");

                    b.HasIndex("ProductIDProduct");

                    b.ToTable("PositionProduct");
                });

            modelBuilder.Entity("ProductSupplier", b =>
                {
                    b.Property<Guid>("ProductIDProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("SupplierIDSupplier")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ProductIDProduct", "SupplierIDSupplier");

                    b.HasIndex("SupplierIDSupplier");

                    b.ToTable("ProductSupplier");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Customer", b =>
                {
                    b.Property<Guid>("IDCostumer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Nif")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Tele")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDCostumer");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Intervection", b =>
                {
                    b.Property<Guid>("IDIntervection")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("NameTecnical")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDIntervection");

                    b.ToTable("Intervection");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Machine", b =>
                {
                    b.Property<Guid>("IDMachine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("MachineName")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<Guid?>("OrdersIDOrders")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Size")
                        .HasPrecision(10, 3)
                        .HasColumnType("decimal(10,3)");

                    b.HasKey("IDMachine");

                    b.HasIndex("OrdersIDOrders");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Money", b =>
                {
                    b.Property<Guid>("IDMoney")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CustomerIDCostumer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("FiveEuro")
                        .HasColumnType("int");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<int>("OneCent")
                        .HasColumnType("int");

                    b.Property<int>("OneEuro")
                        .HasColumnType("int");

                    b.Property<int>("QuarterCent")
                        .HasColumnType("int");

                    b.Property<int>("TenCent")
                        .HasColumnType("int");

                    b.Property<int>("TwentyCent")
                        .HasColumnType("int");

                    b.HasKey("IDMoney");

                    b.HasIndex("CustomerIDCostumer");

                    b.ToTable("Money");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Orders", b =>
                {
                    b.Property<Guid>("IDOrders")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Cost")
                        .HasPrecision(10, 3)
                        .HasColumnType("decimal(10,3)");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("CustomerIDCostumer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("Date")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("NameTecnical")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDOrders");

                    b.HasIndex("CustomerIDCostumer");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Position", b =>
                {
                    b.Property<Guid>("IDPosition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDPosition");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Product", b =>
                {
                    b.Property<Guid>("IDProduct")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ingredients")
                        .HasMaxLength(500)
                        .HasColumnType("varchar");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<Guid?>("OrderIDOrders")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal?>("Price")
                        .HasPrecision(10, 3)
                        .HasColumnType("decimal(10,3)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("IDProduct");

                    b.HasIndex("OrderIDOrders");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Supplier", b =>
                {
                    b.Property<Guid>("IDSupplier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Address")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Nif")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Tele")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDSupplier");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Support", b =>
                {
                    b.Property<Guid>("IDSupport")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("DeleteAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("bit");

                    b.Property<DateTime?>("LastUpdateAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Nif")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<Guid?>("OrdersIDOrders")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Tele")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDSupport");

                    b.HasIndex("OrdersIDOrders");

                    b.ToTable("Support");
                });

            modelBuilder.Entity("IntervectionMachine", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Intervection", null)
                        .WithMany()
                        .HasForeignKey("IntervectionIDIntervection")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiSnackMachine.Models.Machine", null)
                        .WithMany()
                        .HasForeignKey("MachineIDMachine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntervectionSupport", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Intervection", null)
                        .WithMany()
                        .HasForeignKey("IntervectionIDIntervection")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiSnackMachine.Models.Support", null)
                        .WithMany()
                        .HasForeignKey("SupportIDSupport")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MachinePosition", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Machine", null)
                        .WithMany()
                        .HasForeignKey("MachineIDMachine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiSnackMachine.Models.Position", null)
                        .WithMany()
                        .HasForeignKey("PositionIDPosition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MachineProduct", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Machine", null)
                        .WithMany()
                        .HasForeignKey("MachineIDMachine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiSnackMachine.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductIDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MachineSupport", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Machine", null)
                        .WithMany()
                        .HasForeignKey("MachineIDMachine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiSnackMachine.Models.Support", null)
                        .WithMany()
                        .HasForeignKey("SupportIDSupport")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PositionProduct", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Position", null)
                        .WithMany()
                        .HasForeignKey("PositionIDPosition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiSnackMachine.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductIDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductSupplier", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("ProductIDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiSnackMachine.Models.Supplier", null)
                        .WithMany()
                        .HasForeignKey("SupplierIDSupplier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Machine", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Orders", null)
                        .WithMany("Machine")
                        .HasForeignKey("OrdersIDOrders");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Money", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Customer", "Customer")
                        .WithMany("Money")
                        .HasForeignKey("CustomerIDCostumer");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Orders", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Customer", "Customer")
                        .WithMany("Order")
                        .HasForeignKey("CustomerIDCostumer");

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Product", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Orders", "Order")
                        .WithMany()
                        .HasForeignKey("OrderIDOrders");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Support", b =>
                {
                    b.HasOne("WebApiSnackMachine.Models.Orders", null)
                        .WithMany("Support")
                        .HasForeignKey("OrdersIDOrders");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Customer", b =>
                {
                    b.Navigation("Money");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("WebApiSnackMachine.Models.Orders", b =>
                {
                    b.Navigation("Machine");

                    b.Navigation("Support");
                });
#pragma warning restore 612, 618
        }
    }
}
