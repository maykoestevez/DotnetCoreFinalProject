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
    public class ProductController : Controller
    {
        private readonly IProductService _service;
        public ProductController(IProductService service)
        {
            _service = service;
        }

        // GET api/product
        [HttpGet("")]
        public async Task<IEnumerable<Product>> Gets()
        {
            return await _service.GetAll();
        }

        // GET api/product/5
        [HttpGet("{id}")]
        public async Task<Product> GetById(int id)
        {
            return await _service.GetById(id);
        }

        // POST api/product
        [HttpPost("")]
        public async Task Post([FromBody] Product product)
        {
            await _service.Add(product);
        }

        // PUT api/product/5
        [HttpPut()]
        public async Task Put([FromBody] Product product)
        {
            await _service.Update(product);
        }

        // DELETE api/product/5
        [HttpDelete("{id}")]
        public async Task DeleteById(int id)
        {
            await _service.Delete(id);
        }
    }
}