using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        // GET: api/<ProductController>
        [HttpGet]
        public async Task<IEnumerable<Product>> Get()
        {
            return await _productService.GetProductsByIncludeAsync();
        }

        // GET api/<ProductController>/5
        [HttpGet("{id}")]
        public async Task<Product> Get(Guid id)
        {
            return await _productService.GetProductByIncludeAsync(id);
        }

        // POST api/<ProductController>
        [HttpPost]
        public async void Post([FromBody] Product value)
        {
            await _productService.AddAsync(value);
        }

        // PUT api/<ProductController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody] Product value)
        {
            await _productService.UpdateAsync(value, id);
        }

        // DELETE api/<ProductController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _productService.SoftDeleteAsync(id);
        }
    }
}
