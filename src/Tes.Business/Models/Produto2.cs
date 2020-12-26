using System;
using System.Collections.Generic;
using System.Text;

namespace Tes.Business.Models
{
    public class Produto2 :Entity
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public IEnumerable<OrcamentoProduto> OrcamentoProdutos { get; set; }
    }
}
