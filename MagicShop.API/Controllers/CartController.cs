using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartController : ControllerBase
    {
        private readonly ICartService _cartService;

        public CartController(ICartService cartService)
        {
            _cartService = cartService;
        }

        // GET: api/<CartController>
        [HttpGet]
        public async Task<IEnumerable<Cart>> Get()
        {
            return await _cartService.GetCartsByIncludeAsync();
        }

        // GET api/<CartController>/5
        [HttpGet("{id}")]
        public async Task<Cart> Get(Guid id)
        {
            return await _cartService.GetCartByIncludeAsync(id);
        }

        // POST api/<CartController>
        [HttpPost]
        public async void Post([FromBody] Cart value)
        {
            await _cartService.AddAsync(value);
        }

        // PUT api/<CartController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody] Cart value)
        {
            await _cartService.UpdateAsync(value, id);
        }

        // DELETE api/<CartController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _cartService.SoftDeleteAsync(id);
        }
    }
}
