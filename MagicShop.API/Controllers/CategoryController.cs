using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<IEnumerable<Category>> Get()
        {
            return await _categoryService.GetCategoriesByIncludeAsync();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<Category> Get(Guid id)
        {
            return await _categoryService.GetCategoryByIncludeAsync(id);
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async void Post([FromBody] Category value)
        {
            await _categoryService.AddAsync(value);
        }

        // PUT api/<CategoryController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody] Category value)
        {
            await _categoryService.UpdateAsync(value, id);
        }

        // DELETE api/<CategoryController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _categoryService.SoftDeleteAsync(id);
        }
    }
}
