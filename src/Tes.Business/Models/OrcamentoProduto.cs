using System;
using System.Collections.Generic;
using System.Text;
using Tes.Business.Models;

namespace Tes.Business.Models
{
    public class OrcamentoProduto: Entity
    {
        public Guid OrcamentoId { get; set; }
        public Guid ProdutoId { get; set; }
        public Produto2 Produto { get; set; }
        public Orcamento Orcamento { get; set; }
    }
}

