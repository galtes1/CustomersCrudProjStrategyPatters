using Microsoft.EntityFrameworkCore;
using StrategyPatters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPatters.Db
{
    internal class NorthwindContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=GALT\\SQL2019;Database=Northwind;Trusted_Connection=True;TrustServerCertificate=True;");
        }
    }
}
