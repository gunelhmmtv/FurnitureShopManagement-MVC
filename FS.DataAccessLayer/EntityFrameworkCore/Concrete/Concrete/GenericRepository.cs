﻿using FS.DataAccessLayer.EntityFrameworkCore.Abstract;
using FS.DataAccessLayer.EntityFrameworkCore.Contexts;
using FS.Entity.Commons;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace FS.DataAccessLayer.EntityFrameworkCore.Concrete.Concrete
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private readonly FsContext _dbContext;

        protected DbSet<T> TableEntity => _dbContext.Set<T>();
        public GenericRepository(FsContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task<bool> AddAsync(T entity)
        {
            var addedState = await TableEntity.AddAsync(entity);
            return addedState.State == EntityState.Added;
        }

        public async Task<IEnumerable<T>> GetAllAsync(bool tracking = true)
        {
            if (tracking is false)
            {
                return await TableEntity.AsNoTracking().ToListAsync();
            }
            return await TableEntity.ToListAsync();
        }

        public async Task<T> GetByIdAsync(int id) => await TableEntity.FindAsync(id);

        public IQueryable<T> GetWhereAsync(Expression<Func<T, bool>> expression)
            => TableEntity.Where(expression);

        public bool Remove(T entity)
        {
            var removed = TableEntity.Remove(entity);
            return removed.State == EntityState.Deleted;
        }

        public bool Update(T entity)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            return true;
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

    
    }
}
