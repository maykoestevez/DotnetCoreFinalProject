using System.Linq;
using System.Threading.Tasks;
using finalProject.Repositories;
using finalProjectApi.Models;
using Microsoft.EntityFrameworkCore;

namespace finalProjectApi.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        private readonly FinalProjectDbContext _dbcontext;
        public UserRepository(FinalProjectDbContext dbContext) : base(dbContext)
        {
            _dbcontext = dbContext;
        }

        public async Task<bool> IsAdmin(int userId)
        {
            var user = await _dbcontext.User.Where(x => x.Role).FirstOrDefaultAsync();
            return user.Role;//True=Admin,False=Normal
        }

        public Task<User> Login(string user, string password)
        {
            return _dbcontext.User
              .Where(u => u.UserName == user && u.Password == password).FirstOrDefaultAsync();
        }
    }
}