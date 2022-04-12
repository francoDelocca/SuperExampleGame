using Microsoft.EntityFrameworkCore;
using SuperExampleGame.Domain.Domain;
using SuperExampleGame.Infraestructure.Data.Configs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExampleGame.Infraestructure.Data.Context
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Transaction> Transactions { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=(LocalDb)\\MSSQLLocalDB;Initial Catalog=VentasApp;");
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            builder.ApplyConfiguration(new TransactionConfig());
        }
    }
}
