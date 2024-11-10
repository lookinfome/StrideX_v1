﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using xAPI.Models;

#nullable disable

namespace xAPI.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20241110114111_InitalDeployment")]
    partial class InitalDeployment
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.10");

            modelBuilder.Entity("xAPI.Models.CustomerDetailsModel", b =>
                {
                    b.Property<string>("CustId")
                        .HasColumnType("TEXT");

                    b.Property<string>("CustGender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("CustPhone")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("CustId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("xAPI.Models.InventoryDetailsModel", b =>
                {
                    b.Property<string>("ItemCode")
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemCategory")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemGender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("ItemCode");

                    b.ToTable("Inventory");
                });

            modelBuilder.Entity("xAPI.Models.InventoryItemDetailsModel", b =>
                {
                    b.Property<int>("InvntoryItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ItemCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemSize")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemValue")
                        .HasColumnType("INTEGER");

                    b.HasKey("InvntoryItemId");

                    b.ToTable("InventoryItems");
                });

            modelBuilder.Entity("xAPI.Models.InvoiceDetailsModel", b =>
                {
                    b.Property<string>("InvoiceNumber")
                        .HasColumnType("TEXT");

                    b.Property<float>("InvoiceAmount")
                        .HasColumnType("REAL");

                    b.Property<DateTime>("InvoiceDate")
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("InvoiceNumber");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("xAPI.Models.InvoiceItemDetailsModel", b =>
                {
                    b.Property<int>("InvoiceItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("InvoiceNumber")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("ItemCode")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("ItemUnit")
                        .HasColumnType("INTEGER");

                    b.HasKey("InvoiceItemId");

                    b.ToTable("InvoiceItems");
                });
#pragma warning restore 612, 618
        }
    }
}
