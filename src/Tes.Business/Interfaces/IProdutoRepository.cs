using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tes.Business.Models;

namespace Tes.Business.Interfaces
{
    public interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutoPorFornecedor(Guid FornecedorId);
        Task<IEnumerable<Produto>> ObterProdutoFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid Id);
    }
}
