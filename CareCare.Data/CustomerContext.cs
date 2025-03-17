
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.ComponentModel.DataAnnotations;

namespace CareCare.Data
{

    public class CustomerContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        //public DbSet<Vehicles> Vehicle { get; set; }
        //public DbSet<Tinting> Tinting { get; set; }

        public string DbPath { get; }
        public bool VerboseSQL { get; set; } = true;

        private void LogtoDebug(string logMessage)
        {
            if (VerboseSQL)
            {
                Console.WriteLine(logMessage);
            }
        }

        public CustomerContext()
        {
            var folder = Environment.SpecialFolder.LocalApplicationData;
            var path = Environment.GetFolderPath(folder);
            DbPath = System.IO.Path.Join(path, "customer.db");
            this.Database.EnsureCreated();
        }
        
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            IEnumerable<string> dogs = [DbLoggerCategory.Database.Command.Name];

            optionsBuilder
                .UseSqlite($"Data Source={DbPath}")
                .EnableSensitiveDataLogging()
                .LogTo(LogtoDebug,
                new[] { DbLoggerCategory.Database.Command.Name },
                LogLevel.Information,
                DbContextLoggerOptions.None
                );
            //Ignore the DisplayFormatAttribute
            //modelBuilder.Ignore<DisplayFormatAttribute>();
            //modelBuilder.Ignore<EmailAddressAttribute>();
            //modelBuilder.Ignore<PhoneAttribute>();

            //base.OnModelCreating(modelBuilder);
        }

    }


}
