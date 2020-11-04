using CRMmodel.models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace CRMmodel.CRMDBContext
{
    /*
     * 
     * Tools-> Nuget Package manager -> Package Manager Console
     * 
     * add-migration <a name>
     * update-database
    */




    public class AppDbContext:DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderProduct> OrderProducts { get; set; }

        private readonly string connectionString =
            "Server =localhost; " +
            "Database =crmModel; " +
            "User Id =sa; " +
            "Password =passw0rd;";

        protected override void OnConfiguring
            (DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
