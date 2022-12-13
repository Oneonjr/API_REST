using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API_REST.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Data;
using API_REST.Enum;


namespace API_REST.Context.Map
{
    public class VendasMap : IEntityTypeConfiguration<Vendas>
    {
        public void Configure(EntityTypeBuilder<Vendas> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.QuantidadeItens).HasDefaultValue(1);
            builder.Property(x => x.Status).HasColumnName("id_Status").HasConversion<string>();
            builder.Property(x => x.VendedorId).HasColumnName("id_Vendedor").IsRequired();
            builder.HasOne(x =>x.Vendedor).WithMany(x => x.Vendas).HasForeignKey(x => x.VendedorId);



        }
    }
}