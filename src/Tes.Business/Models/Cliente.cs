using System;
using System.Collections.Generic;
using System.Text;

namespace Tes.Business.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; set; }

        public string Telefone { get; set; }

        public IEnumerable<Orcamento> Orcamentos { get; set; }
    }
}
