using Microsoft.EntityFrameworkCore;
using Salik_Inventory_Management_System.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salik_Inventory_Management_System.UI.DataAccess
{
    public class InventoryManagementSystemDbContext : DbContext
    {
        public DbSet<CustomerModel> Customers{get;set; }
        public DbSet<InvoiceModel> Invoices{get;set; }
        public DbSet<ItemModel> Items{get;set; }
        public DbSet<OrderItem> OrderItem{get;set; }
        public DbSet<OrderModel> Orders{get;set; }
        public DbSet<Payment> Payments{get;set; }
        public DbSet<CompanyPayment> companyPayments{get;set; }
        public DbSet<MardCompany> mardCompany{get;set; }
        public DbSet<User> User { get; set; }


        public InventoryManagementSystemDbContext(DbContextOptions<InventoryManagementSystemDbContext> options) : base(options)  { }


        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //configuration of the many to many relationship
            modelBuilder.Entity<OrderItem>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<OrderItem>()
               .HasOne(bc => bc.item)
               .WithMany(bc => bc.ItemOrderedList)
               .HasForeignKey(bc => bc.ItemModelId)
               .OnDelete(DeleteBehavior.SetNull);
               

            modelBuilder.Entity<OrderItem>()
              .HasOne(bc => bc.order)
              .WithMany(bc => bc.orderedItems)
              .HasForeignKey(bc => bc.OrderModelId)
              .OnDelete(DeleteBehavior.Cascade);



            modelBuilder.Entity<CustomerModel>()
                .HasMany(p => p.Orders)
                .WithOne(p => p.customerModel)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<CustomerModel>()
                .HasMany(d => d.payments)
                .WithOne(d => d.Customer)
                .OnDelete(DeleteBehavior.Cascade);


            modelBuilder.Entity<OrderModel>()
                .HasMany(d => d.Invoices)
                .WithOne(d => d.order)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<CustomerModel>()
                .Property(d => d.TotalMoneyOwed)
                .HasDefaultValue(decimal.Zero);

            modelBuilder.Entity<MardCompany>()
                .HasMany(d => d.Items)
                .WithOne(d => d.company)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<MardCompany>()
                .HasMany(d => d.PaymentsReceivedFromTheUser)
                .WithOne(d => d.company)
                .OnDelete(DeleteBehavior.NoAction);
                

            base.OnModelCreating(modelBuilder);
        }
    }
}
