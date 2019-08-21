using System.Collections.Generic;
using System.Threading.Tasks;
using finalProject.Repositories;
using finalProjectApi.Models;

namespace finalProjectApi.Services
{

    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        public UserService(IUserRepository repository)
        {
            _repository = repository;
        }

        public async Task Add(User user)
        {
            await _repository.Add(user);
        }

        public Task Delete(int userId)
        {
            return _repository.Delete(userId);
        }

        public async Task<IEnumerable<User>> GetAll()
        {
            return await _repository.GetAll();
        }

        public async Task<User> GetById(int id)
        {
            return await _repository.GetById(id);
        }

        public async Task<bool> IsAdmin(int userId)
        {
            return await _repository.IsAdmin(userId);
        }

        public async Task<User> Login(string user, string password)
        {
            var userResult= await _repository.Login(user, password);
            Helper.IsLogged=true;
            return userResult;

        }

        public async Task Update(User user)
        {
            await _repository.Update(user);
        }


    }
}