using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;
using Tes.Business.Models;

namespace Tes.Data.Mapping
{
    public class OrcamentoProdutoMapping : IEntityTypeConfiguration<OrcamentoProduto>
    {
        public void Configure(EntityTypeBuilder<OrcamentoProduto> builder)
        {
            builder.ToTable("OrcamentoProduto");
        }
    }
}
