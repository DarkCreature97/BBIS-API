﻿// <auto-generated />
using System;
using BBIS_API.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace BBIS_API.Migrations
{
    [DbContext(typeof(DatabaseContext))]
    partial class DatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("BBIS_API.Models.OrderItem", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<long?>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("StockAmount")
                        .HasColumnType("int");

                    b.Property<double>("WarehousePrice")
                        .HasColumnType("float");

                    b.HasKey("OrderID");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderItems");
                });

            modelBuilder.Entity("BBIS_API.Models.ProductItem", b =>
                {
                    b.Property<long>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("Alcoholic")
                        .HasColumnType("bit");

                    b.Property<string>("Brand")
                        .IsRequired()
                        .HasColumnType("nvarchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("ContainerType")
                        .IsRequired()
                        .HasColumnType("nvarchar(10)")
                        .HasMaxLength(10);

                    b.Property<double>("Discount")
                        .HasColumnType("float");

                    b.Property<string>("Flavour")
                        .IsRequired()
                        .HasColumnType("nvarchar(60)")
                        .HasMaxLength(60);

                    b.Property<bool>("Returnable")
                        .HasColumnType("bit");

                    b.Property<double>("SellPrice")
                        .HasColumnType("float");

                    b.Property<int>("StockAmount")
                        .HasColumnType("int");

                    b.HasKey("ProductId");

                    b.ToTable("ProductItems");
                });

            modelBuilder.Entity("BBIS_API.Models.SellItem", b =>
                {
                    b.Property<long>("SellID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DiscountApplied")
                        .HasColumnType("bit");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint");

                    b.Property<long?>("ProductObjProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("SellAmount")
                        .HasColumnType("int");

                    b.Property<DateTime>("SellDate")
                        .HasColumnType("datetime2");

                    b.Property<double>("SellPriceTotal")
                        .HasColumnType("float");

                    b.HasKey("SellID");

                    b.HasIndex("ProductObjProductId");

                    b.ToTable("SellItems");
                });

            modelBuilder.Entity("BBIS_API.Models.OrderItem", b =>
                {
                    b.HasOne("BBIS_API.Models.ProductItem", "Product")
                        .WithMany("OrdersList")
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("BBIS_API.Models.SellItem", b =>
                {
                    b.HasOne("BBIS_API.Models.ProductItem", "ProductObj")
                        .WithMany("SalesList")
                        .HasForeignKey("ProductObjProductId");
                });
#pragma warning restore 612, 618
        }
    }
}
