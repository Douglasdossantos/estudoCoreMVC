using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Tes.Business.Interfaces;
using Tes.Business.Models;
using Tes.Data.Context;

namespace Tes.Data.Repository
{
    public class Produto2Repository : Repository<Produto2>, IProduto2Repository
    {
        public Produto2Repository(TesDbContext context) : base(context) { }
       
        public Task<Produto2> ObterProdutoOrcamento(Guid IdOrcamento)
        {
            throw new NotImplementedException();
        }
    }
}
