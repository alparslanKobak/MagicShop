using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogPostController : ControllerBase
    {
        private readonly IBlogPostService _blogPostService;

        public BlogPostController(IBlogPostService blogPostService)
        {
            _blogPostService = blogPostService;
        }

        // GET: api/<BlogPostController>
        [HttpGet]
        public async Task<IEnumerable<BlogPost>> Get()
        {
            return await _blogPostService.GetBlogPostsByIncludeAsync();
        }

        // GET api/<BlogPostController>/5
        [HttpGet("{id}")]
        public async Task<BlogPost> Get(Guid id)
        {
            return await _blogPostService.GetBlogPostByIncludeAsync(id);
        }

        // POST api/<BlogPostController>
        [HttpPost]
        public async void Post([FromBody] BlogPost value)
        {
            await _blogPostService.AddAsync(value);
        }

        // PUT api/<BlogPostController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody] BlogPost value)
        {
            await _blogPostService.UpdateAsync(value, id);
        }

        // DELETE api/<BlogPostController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _blogPostService.SoftDeleteAsync(id);
        }
    }
}
