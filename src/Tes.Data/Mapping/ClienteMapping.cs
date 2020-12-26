using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tes.Business.Models;

namespace Tes.Data.Mapping
{
    public class ClienteMapping : IEntityTypeConfiguration<Cliente>
    {
        public void Configure(EntityTypeBuilder<Cliente> builder)
        {
            builder.ToTable("Clientes");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");
            builder.Property(p => p.Telefone)
                .IsRequired()
                .HasColumnType("varchar(50)");
            builder.HasMany(f => f.Orcamentos)
                .WithOne(e => e.Cliente)
                .HasForeignKey(r => r.ClienteId);

            //builder.HasMany(c => c.Orcamentos)
            //    .WithOne(s => s.Cliente)
            //    .HasForeignKey(s => s.ClienteId);
        }
    }
}
