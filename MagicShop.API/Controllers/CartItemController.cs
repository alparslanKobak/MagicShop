using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CartItemController : ControllerBase
    {
        private readonly ICartItemService _cartItemService;

        public CartItemController(ICartItemService cartItemService)
        {
            _cartItemService = cartItemService;
        }

        // GET: api/<CartItemController>
        [HttpGet]
        public async Task<IEnumerable<CartItem>> Get()
        {
            return await _cartItemService.GetCartItemsByIncludeAsync();
        }

        // GET api/<CartItemController>/5
        [HttpGet("{id}")]
        public async Task<CartItem> Get(Guid id)
        {
            return await _cartItemService.GetCartItemByIncludeAsync(id);
        }

        // POST api/<CartItemController>
        [HttpPost]
        public async void Post([FromBody] CartItem value)
        {
            await _cartItemService.AddAsync(value);
        }

        // PUT api/<CartItemController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody] CartItem value)
        {
            await _cartItemService.UpdateAsync(value, id);
        }

        // DELETE api/<CartItemController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _cartItemService.SoftDeleteAsync(id);
        }
    }
}
