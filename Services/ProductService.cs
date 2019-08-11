using System.Collections.Generic;
using System.Threading.Tasks;
using finalProjectApi.Models;
using finalProjectApi.Repositories;

namespace finalProjectApi.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _repository;
        public ProductService(IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(Product product)
        {
            await _repository.Add(product);
        }

        public async Task Delete(int productId)
        {
            await _repository.Delete(productId);
        }

        public async Task<IEnumerable<Product>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<Product> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task Update(Product product)
        {
            await _repository.Update(product);
        }
    }
}