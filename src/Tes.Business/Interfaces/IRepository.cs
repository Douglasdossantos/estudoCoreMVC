using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tes.Business.Models;

namespace Tes.Business.Interfaces
{
    public interface IRepository<TEntity> : IDisposable where TEntity : Entity
    {
        Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate);
        Task Adicionar(TEntity entity);
        Task<TEntity> ObterPorID(Guid id);
        Task<List<TEntity>> obterTodos();
        Task atualizar(TEntity entity);
        Task Delete(Guid Id);
        Task<int> SaveChanges();
    }

}
