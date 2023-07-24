﻿// <auto-generated />
using System;
using ConsoleSnackMachine.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ConsoleSnackMachine.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ConsoleSnackMachine.Models.Costumer", b =>
                {
                    b.Property<Guid>("IDCostumer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Tele")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDCostumer");

                    b.ToTable("Costumer");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Intervetion", b =>
                {
                    b.Property<Guid>("IDIntervetion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Cost")
                        .HasColumnType("decimal(10,2)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("NameTecnical")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDIntervetion");

                    b.ToTable("Intervetion");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Machine", b =>
                {
                    b.Property<Guid>("IDMachine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Location")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Size")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("IDMachine");

                    b.ToTable("Machine");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Money", b =>
                {
                    b.Property<Guid>("IDMoney")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("FiveEuro")
                        .HasColumnType("int");

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

                    b.ToTable("Money");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Orders", b =>
                {
                    b.Property<Guid>("IDOrder")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDOrder");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Position", b =>
                {
                    b.Property<Guid>("IDPosition")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Descripiton")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDPosition");

                    b.ToTable("Position");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Product", b =>
                {
                    b.Property<Guid>("IDProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("ExpDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ingredients")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(10,3)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.HasKey("IDProduct");

                    b.ToTable("Product");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Supplier", b =>
                {
                    b.Property<Guid>("IDSupplier")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adrress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("NIF")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Tele")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDSupplier");

                    b.ToTable("Supplier");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Support", b =>
                {
                    b.Property<Guid>("IDSupport")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Adress")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Nif")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.Property<string>("Tele")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDSupport");

                    b.ToTable("Support");
                });

            modelBuilder.Entity("IntervetionMachine", b =>
                {
                    b.Property<Guid>("IDIntervetion")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDMachine")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDIntervetion", "IDMachine");

                    b.HasIndex("IDMachine");

                    b.ToTable("IntervetionMachine");
                });

            modelBuilder.Entity("MachinePosition", b =>
                {
                    b.Property<Guid>("IDMachine")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDPosition")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDMachine", "IDPosition");

                    b.HasIndex("IDPosition");

                    b.ToTable("MachinePosition");
                });

            modelBuilder.Entity("MachineProduct", b =>
                {
                    b.Property<Guid>("IDMachine")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDProduct")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDMachine", "IDProduct");

                    b.HasIndex("IDProduct");

                    b.ToTable("MachineProduct");
                });

            modelBuilder.Entity("MachineSupport", b =>
                {
                    b.Property<Guid>("IDMachine")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSupport")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDMachine", "IDSupport");

                    b.HasIndex("IDSupport");

                    b.ToTable("MachineSupport");
                });

            modelBuilder.Entity("PositionProduct", b =>
                {
                    b.Property<Guid>("IDPosition")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDProduct")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDPosition", "IDProduct");

                    b.HasIndex("IDProduct");

                    b.ToTable("PositionProduct");
                });

            modelBuilder.Entity("ProductSupplier", b =>
                {
                    b.Property<Guid>("IDProduct")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSupplier")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IDProduct", "IDSupplier");

                    b.HasIndex("IDSupplier");

                    b.ToTable("ProductSupplier");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Costumer", b =>
                {
                    b.HasOne("ConsoleSnackMachine.Models.Orders", null)
                        .WithMany("Costumer")
                        .HasForeignKey("IDCostumer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Money", b =>
                {
                    b.HasOne("ConsoleSnackMachine.Models.Costumer", null)
                        .WithMany("Money")
                        .HasForeignKey("IDMoney")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Product", b =>
                {
                    b.HasOne("ConsoleSnackMachine.Models.Orders", null)
                        .WithMany("Product")
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("IntervetionMachine", b =>
                {
                    b.HasOne("ConsoleSnackMachine.Models.Machine", null)
                        .WithMany()
                        .HasForeignKey("IDIntervetion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleSnackMachine.Models.Intervetion", null)
                        .WithMany()
                        .HasForeignKey("IDMachine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MachinePosition", b =>
                {
                    b.HasOne("ConsoleSnackMachine.Models.Position", null)
                        .WithMany()
                        .HasForeignKey("IDMachine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleSnackMachine.Models.Machine", null)
                        .WithMany()
                        .HasForeignKey("IDPosition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MachineProduct", b =>
                {
                    b.HasOne("ConsoleSnackMachine.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("IDMachine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleSnackMachine.Models.Machine", null)
                        .WithMany()
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MachineSupport", b =>
                {
                    b.HasOne("ConsoleSnackMachine.Models.Support", null)
                        .WithMany()
                        .HasForeignKey("IDMachine")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleSnackMachine.Models.Machine", null)
                        .WithMany()
                        .HasForeignKey("IDSupport")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PositionProduct", b =>
                {
                    b.HasOne("ConsoleSnackMachine.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("IDPosition")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleSnackMachine.Models.Position", null)
                        .WithMany()
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ProductSupplier", b =>
                {
                    b.HasOne("ConsoleSnackMachine.Models.Supplier", null)
                        .WithMany()
                        .HasForeignKey("IDProduct")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ConsoleSnackMachine.Models.Product", null)
                        .WithMany()
                        .HasForeignKey("IDSupplier")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Costumer", b =>
                {
                    b.Navigation("Money");
                });

            modelBuilder.Entity("ConsoleSnackMachine.Models.Orders", b =>
                {
                    b.Navigation("Costumer");

                    b.Navigation("Product");
                });
#pragma warning restore 612, 618
        }
    }
}
