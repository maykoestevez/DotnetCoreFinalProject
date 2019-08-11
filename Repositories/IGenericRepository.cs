using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace finalProjectApi.Repositories
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        Task<IEnumerable<TEntity>> GetAll();
        Task<TEntity> GetById(int id);
        Task Add(TEntity entity);
        Task Delete(int entityId);
        Task Update(TEntity entity);
        Task DeleteRange(IEnumerable<TEntity> entity);
        Task AddRange(IEnumerable<TEntity> entity);
        Task UpdateRange(IEnumerable<TEntity> entity);

    }

}
