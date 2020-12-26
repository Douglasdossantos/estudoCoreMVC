using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tes.Business.Models;

namespace Tes.Business.Interfaces
{
    public interface IOrcamentoRepository : IRepository<Orcamento>
    {
        Task<Orcamento> ObterOrcamentoCliente(Guid IdCliente);
    }
}
