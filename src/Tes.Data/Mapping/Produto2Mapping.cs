using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tes.Business.Models;

namespace Tes.Data.Mapping
{
    public class Produto2Mapping : IEntityTypeConfiguration<Produto2>
    {
        public void Configure(EntityTypeBuilder<Produto2> builder)
        {
            builder.ToTable("Produtos2");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Nome)
                .IsRequired()
                .HasColumnType("varchar(200)");
            builder.Property(p => p.Preco)
                .IsRequired()
                .HasColumnType("decimal(18,2)");

            builder.HasMany(p => p.OrcamentoProdutos)
                .WithOne(s => s.Produto)
                .HasForeignKey(s => s.ProdutoId);
        }
    }
}
