﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using EventMaker.BLL.Interfaces;
using EventMaker.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace EventMaker.BLL.Repository
{
    /// <inheritdoc cref="IRepository<T>"/>
    public class RepositoryManager<T> : IRepository<T> where T : class
    {
        private readonly DbSet<T> _dbSet;
        private readonly DbContext _context;

        public RepositoryManager(EventMakerDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
            _dbSet = context.Set<T>();
        }

        public async Task AddAsync(T entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public async Task AddRangeAsync(IEnumerable<T> entities)
        {
            await _dbSet.AddRangeAsync(entities);
        }

        public void Delete(T entity)
        {
            _dbSet.Remove(entity);
        }

        public void DeleteRange(IEnumerable<T> entity)
        {
            _dbSet.RemoveRange(entity);
        }

        public IQueryable<T> GetAllWithoutTracking()
        {
            return _dbSet.AsNoTracking();
        }

        public async Task<T> GetEntityAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.FirstOrDefaultAsync(predicate);
        }

        public async Task<T> GetEntityWithoutTrackingAsync(Expression<Func<T, bool>> predicate)
        {
            return await _dbSet.AsNoTracking().FirstOrDefaultAsync(predicate);
        }

        public Task SaveChangesAsync()
        {
            return _context.SaveChangesAsync();
        }

        public void Update(T entity)
        {
            _context.Entry(entity).State = EntityState.Modified;
        }
    }
}
