using System.Collections.Generic;
using System.Threading.Tasks;
using finalProjectApi.Models;

namespace finalProjectApi.Services
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetAll();
        Task<Product> GetById(int id);
        Task Add(Product product);
        Task Delete(int productId);
        Task Update(Product product);
    }
}