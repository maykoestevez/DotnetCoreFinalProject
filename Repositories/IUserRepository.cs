using System.Threading.Tasks;
using finalProjectApi.Models;
using finalProjectApi.Repositories;

namespace finalProject.Repositories
{
    public interface IUserRepository : IGenericRepository<User>
    {
        Task<User> Login(string user, string password);
        Task<bool> IsAdmin(int userId);
    }
}