
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CareCare.Data
{

    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Vehicles> Vehicle { get; set; }
        public DbSet<Tinting> Tinting { get; set; }

        public string DbPath { get; }

        public CustomerContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "customer.db");
            this.Database.EnsureCreated();
        }
       
        // The following configures EF to create a Sqlite database file in the
        // special "local" folder for your platform.
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite($"Data Source={DbPath}");
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Ignore the DisplayFormatAttribute
            modelBuilder.Ignore<DisplayFormatAttribute>();
            modelBuilder.Ignore<EmailAddressAttribute>();
            modelBuilder.Ignore<PhoneAttribute>();

            base.OnModelCreating(modelBuilder);
        }
    }

}
