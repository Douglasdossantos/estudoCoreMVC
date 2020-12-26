using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tes.Business.Models;

namespace Tes.Data.Mapping
{
    public class OrcamentoMapping : IEntityTypeConfiguration<Orcamento>
    {
        public void Configure(EntityTypeBuilder<Orcamento> builder)
        {
            builder.ToTable("Orcamentos");
            builder.Property(p => p.Data).HasColumnType("datetime");

            builder.HasMany(p => p.OrcamentoProdutos)
               .WithOne(s => s.Orcamento)
               .HasForeignKey(s => s.OrcamentoId);
        }
    }
}
