using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST.Context.Map;
using API_REST.Models;
using Microsoft.EntityFrameworkCore;

namespace API_REST.Context
{
    public class VendasContext : DbContext
    {
        public VendasContext(DbContextOptions<VendasContext> options)
                : base(options)
        {    
        }

        public DbSet<VendedorModel> Vendedor {get; set;}
        public DbSet<Vendas> Vendas {get; set;}
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VendasMap());

            base.OnModelCreating(modelBuilder);
        }

    }
}