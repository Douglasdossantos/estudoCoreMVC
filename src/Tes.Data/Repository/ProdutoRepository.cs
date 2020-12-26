using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tes.Business.Interfaces;
using Tes.Business.Models;
using Tes.Data.Context;

namespace Tes.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(TesDbContext context): base(context)
        {
        }
        public async Task<Produto> ObterProdutoFornecedor(Guid Id)
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor).FirstOrDefaultAsync(p => p.Id == Id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutoFornecedores()
        {
            return await Db.Produtos.AsNoTracking().Include(f => f.Fornecedor)
                .OrderBy(p => p.Nome).ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutoPorFornecedor(Guid FornecedorId)
        {
            return await Buscar(p => p.FornecedorId == FornecedorId);
        }
    }
}
