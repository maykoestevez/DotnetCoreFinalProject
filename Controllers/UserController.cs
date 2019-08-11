using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using finalProjectApi.Models;
using finalProjectApi.Services;
using Microsoft.AspNetCore.Mvc;
//using finalProjectApi.Models;

namespace finalProjectApi.Controllers
{
    [Route("api/[controller]")]
    public class UserController : Controller
    {
        private readonly IUserService _service;
        public UserController(IUserService service)
        {
            _service = service;
        }

        // GET api/user
        [HttpGet("")]
        public async Task<IEnumerable<User>> Gets()
        {
            return await _service.GetAll();
        }

        // GET api/user/5
        [HttpGet("{id}")]
        public async Task<User> GetById(int id)
        {
            return await _service.GetById(id);
        }

        // POST api/user
        [HttpPost("")]
        public async Task Post([FromBody] User user)
        {
            await _service.Add(user);
        }

        // PUT api/user/5
        [HttpPut("")]
        public async Task Put([FromBody] User user)
        {
            await _service.Update(user);
        }

        // DELETE api/user/5
        [HttpDelete("{id}")]
        public async Task DeleteById(int id)
        {
            await _service.Delete(id);
        }
    }
}