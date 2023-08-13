﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webApiSnack.Data;

#nullable disable

namespace webApiSnack.Migrations
{
    [DbContext(typeof(DataContext))]
    partial class DataContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("webApiSnack.Models.Customer", b =>
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

            modelBuilder.Entity("webApiSnack.Models.Money", b =>
                {
                    b.Property<Guid>("IDMoney")
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAt")
                        .HasColumnType("datetime2");

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

                    b.ToTable("Money");
                });

            modelBuilder.Entity("webApiSnack.Models.Money", b =>
                {
                    b.HasOne("webApiSnack.Models.Customer", "Customer")
                        .WithOne("Money")
                        .HasForeignKey("webApiSnack.Models.Money", "IDMoney")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("webApiSnack.Models.Customer", b =>
                {
                    b.Navigation("Money");
                });
#pragma warning restore 612, 618
        }
    }
}
