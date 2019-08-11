using finalProject.Repositories;
using finalProjectApi.Models;

namespace finalProjectApi.Repositories
{
    public class ProductRepository : GenericRepository<Product>, IProductRepository
    {
        private readonly FinalProjectDbContext _dbContext;
        public ProductRepository(FinalProjectDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }
    }
}