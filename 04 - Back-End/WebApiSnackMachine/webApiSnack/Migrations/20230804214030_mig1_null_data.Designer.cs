﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webApiSnack.Data;

#nullable disable

namespace webApiSnack.Migrations
{
    [DbContext(typeof(DataContext))]
    [Migration("20230804214030_mig1_null_data")]
    partial class mig1_null_data
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Tele")
                        .HasMaxLength(255)
                        .HasColumnType("varchar");

                    b.HasKey("IDCostumer");

                    b.ToTable("Customer");
                });
#pragma warning restore 612, 618
        }
    }
}
