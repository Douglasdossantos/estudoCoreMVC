using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tes.Business.Models;

namespace Tes.Business.Interfaces
{
    public interface IProduto2Repository :IRepository<Produto2>
    {
        Task<Produto2> ObterProdutoOrcamento(Guid IdOrcamento);       

    }
}
