using System;
using System.Collections.Generic;
using System.Text;

namespace Tes.Business.Models
{
    public class Orcamento : Entity
    {
        public Guid ClienteId { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }


        public IEnumerable<OrcamentoProduto> OrcamentoProdutos { get; set; }
    }
}
