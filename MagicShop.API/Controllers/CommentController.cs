using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        // GET: api/<CommentController>
        [HttpGet]
        public async Task<IEnumerable<Comment>> Get()
        {
            return await _commentService.GetCommentsByIncludeAsync();
        }

        // GET api/<CommentController>/5
        [HttpGet("{id}")]
        public async Task<Comment> Get(Guid id)
        {
            return await _commentService.GetCommentByIncludeAsync(id);
        }

        // POST api/<CommentController>
        [HttpPost]
        public async void Post([FromBody] Comment value)
        {
            await _commentService.AddAsync(value);
        }

        // PUT api/<CommentController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody] Comment value)
        {
            await _commentService.UpdateAsync(value, id);
        }

        // DELETE api/<CommentController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _commentService.SoftDeleteAsync(id);
        }
    }
}
