using System.Collections.Generic;
using System.Threading.Tasks;
using finalProjectApi.Models;

namespace finalProjectApi.Services
{
    public interface IUserService
    {
        Task<IEnumerable<User>> GetAll();
        Task<User> GetById(int id);
        Task Add(User user);
        Task Delete(int userId);
        Task Update(User user);
        Task<User> Login(string user, string password);
        Task<bool> IsAdmin(int userId);

    }
}