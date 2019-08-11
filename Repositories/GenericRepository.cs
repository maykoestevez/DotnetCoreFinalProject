using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

using finalProjectApi.Models;

namespace finalProjectApi.Repositories
{
    public class GenericRepository<TEntity> : IGenericRepository<TEntity> where TEntity : class
    {
        private readonly FinalProjectDbContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public GenericRepository(FinalProjectDbContext context)
        {
            _context = context;
            _dbSet = context.Set<TEntity>();
        }

        public virtual async Task<IEnumerable<TEntity>> GetAll()
        {
            IQueryable<TEntity> query = _dbSet;
            return await query.ToListAsync().ConfigureAwait(false);
        }

        public virtual async Task<TEntity> GetById(int id)
        {
            return await _dbSet.FindAsync(id).ConfigureAwait(false);
        }

        public virtual async Task Add(TEntity entity)
        {
            _dbSet.Add(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual async Task AddRange(IEnumerable<TEntity> entity)
        {
             await  _dbSet.AddRangeAsync(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual async Task Delete(int entityId)
        {

            var entity = await _dbSet.FindAsync(entityId);
            _dbSet.Remove(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual async Task DeleteRange(IEnumerable<TEntity> entity)
        {
            _dbSet.RemoveRange(entity);
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual async Task Update(TEntity entity)
        {

            _dbSet.Attach(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }

        public virtual async Task UpdateRange(IEnumerable<TEntity> entity)
        {

            _dbSet.AttachRange(entity);
            _context.Entry(entity).State = EntityState.Modified;
            await _context.SaveChangesAsync().ConfigureAwait(false);
        }
    }
}
