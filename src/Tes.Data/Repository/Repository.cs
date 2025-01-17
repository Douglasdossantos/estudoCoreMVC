﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Tes.Business.Interfaces;
using Tes.Business.Models;
using Tes.Data.Context;

namespace Tes.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        protected readonly TesDbContext Db;
        protected readonly DbSet<TEntity> DbSet;

        protected Repository(TesDbContext db)
        {
            Db = db;
            DbSet = db.Set<TEntity>();
        }

        public async Task<IEnumerable<TEntity>> Buscar(Expression<Func<TEntity, bool>> predicate)
        {
            return await DbSet.AsNoTracking().Where(predicate).ToListAsync();
        }
        public virtual async Task<List<TEntity>> obterTodos()
        {
            return await DbSet.ToListAsync();
        }       
        public virtual async Task<TEntity> ObterPorID(Guid id)
        {
            return await DbSet.FindAsync(id);
        }
        public virtual async Task Adicionar(TEntity entity)
        {
            DbSet.Add(entity);
            await SaveChanges();
        }
        public async Task atualizar(TEntity entity)
        {
            DbSet.Update(entity);
            await SaveChanges();
        }
        public virtual async Task Delete(Guid Id)
        {
            DbSet.Remove(new TEntity { Id = Id});
            await SaveChanges();
        }
        public virtual async Task<int> SaveChanges()
        {
            return await Db.SaveChangesAsync();
        }
        public void Dispose()
        {
            Db?.Dispose();
        }

    }
}
