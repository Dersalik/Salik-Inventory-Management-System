﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Salik_Inventory_Management_System.UI.DataAccess;

#nullable disable

namespace Salik_Inventory_Management_System.UI.Migrations
{
    [DbContext(typeof(InventoryManagementSystemDbContext))]
    [Migration("20220909165257_comanyPaymentAndUser")]
    partial class comanyPaymentAndUser
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.CompanyPayment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Amount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int?>("MardCompanyId")
                        .HasColumnType("int");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("MardCompanyId");

                    b.ToTable("companyPayments");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.CustomerModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("TotalMoneyOwed")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("decimal(18,4)")
                        .HasDefaultValue(0m);

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.InvoiceModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime?>("InvoiceDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("OrderModelId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderModelId");

                    b.ToTable("Invoices");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.ItemModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("ItemPrice")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("ItemPriceBought")
                        .HasColumnType("decimal(18,4)");

                    b.Property<double>("ItemQuantity")
                        .HasColumnType("float");

                    b.Property<int?>("MardCompanyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("MardCompanyId");

                    b.ToTable("Items");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.MardCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("TotalMoneyOwedByUserToTheCompany")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("mardCompany");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.OrderItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DateAdded")
                        .HasColumnType("datetime2");

                    b.Property<bool?>("IsHalf")
                        .HasColumnType("bit");

                    b.Property<bool?>("IsQuarter")
                        .HasColumnType("bit");

                    b.Property<int?>("ItemModelId")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("OrderModelId")
                        .HasColumnType("int");

                    b.Property<decimal>("PricePerUnit")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal?>("PriceTotal")
                        .HasColumnType("decimal(18,4)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<string>("description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("ItemModelId");

                    b.HasIndex("OrderModelId");

                    b.ToTable("OrderItem");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.OrderModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CustomerModelId")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OrderDate")
                        .IsRequired()
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("TotalPaymentAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("discount")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerModelId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.Payment", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int?>("CustomerModelId")
                        .HasColumnType("int");

                    b.Property<decimal>("PaymentAmount")
                        .HasColumnType("decimal(18,4)");

                    b.Property<DateTime>("PaymentDate")
                        .HasColumnType("datetime2");

                    b.HasKey("Id");

                    b.HasIndex("CustomerModelId");

                    b.ToTable("Payments");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("TotalMoneyOwedByCustomers")
                        .HasColumnType("decimal(18,4)");

                    b.Property<decimal>("TotalMoneyReceivedFromCustomers")
                        .HasColumnType("decimal(18,4)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.CompanyPayment", b =>
                {
                    b.HasOne("Salik_Inventory_Management_System.UI.Models.MardCompany", "company")
                        .WithMany("PaymentsReceivedFromTheUser")
                        .HasForeignKey("MardCompanyId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("company");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.InvoiceModel", b =>
                {
                    b.HasOne("Salik_Inventory_Management_System.UI.Models.OrderModel", "order")
                        .WithMany("Invoices")
                        .HasForeignKey("OrderModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("order");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.ItemModel", b =>
                {
                    b.HasOne("Salik_Inventory_Management_System.UI.Models.MardCompany", "company")
                        .WithMany("Items")
                        .HasForeignKey("MardCompanyId")
                        .OnDelete(DeleteBehavior.NoAction);

                    b.Navigation("company");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.OrderItem", b =>
                {
                    b.HasOne("Salik_Inventory_Management_System.UI.Models.ItemModel", "item")
                        .WithMany("ItemOrderedList")
                        .HasForeignKey("ItemModelId")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.HasOne("Salik_Inventory_Management_System.UI.Models.OrderModel", "order")
                        .WithMany("orderedItems")
                        .HasForeignKey("OrderModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("item");

                    b.Navigation("order");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.OrderModel", b =>
                {
                    b.HasOne("Salik_Inventory_Management_System.UI.Models.CustomerModel", "customerModel")
                        .WithMany("Orders")
                        .HasForeignKey("CustomerModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("customerModel");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.Payment", b =>
                {
                    b.HasOne("Salik_Inventory_Management_System.UI.Models.CustomerModel", "Customer")
                        .WithMany("payments")
                        .HasForeignKey("CustomerModelId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.CustomerModel", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("payments");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.ItemModel", b =>
                {
                    b.Navigation("ItemOrderedList");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.MardCompany", b =>
                {
                    b.Navigation("Items");

                    b.Navigation("PaymentsReceivedFromTheUser");
                });

            modelBuilder.Entity("Salik_Inventory_Management_System.UI.Models.OrderModel", b =>
                {
                    b.Navigation("Invoices");

                    b.Navigation("orderedItems");
                });
#pragma warning restore 612, 618
        }
    }
}
