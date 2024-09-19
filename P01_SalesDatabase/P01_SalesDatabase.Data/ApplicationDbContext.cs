
using Microsoft.EntityFrameworkCore;
using P01_SalesDatabase.P01_SalesDatabase.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01_SalesDatabase.P01_SalesDatabase.Data
{
    internal class ApplicationDbContext : DbContext
    {

        public DbSet<Product> products { get; set; }
        public DbSet<Customer> customers { get; set; }
        public DbSet<Store> store { get; set; }

        public DbSet<Sale> sales { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(
                "Data Source=PASAA;" +
                "Initial Catalog=Task_1_EF;" +
                "Integrated Security=True;" +
                "TrustServerCertificate=True"
                );
        }
    }
}
