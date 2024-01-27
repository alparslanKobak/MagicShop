using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IService<Contact> _contactService;

        public ContactController(IService<Contact> contactService)
        {
            _contactService = contactService;
        }

        // GET: api/<ContactController>
        [HttpGet]
        public async Task<IEnumerable<Contact>> Get()
        {
            return await _contactService.GetAllAsync();
        }

        // GET api/<ContactController>/5
        [HttpGet("{id}")]
        public async Task<Contact> Get(Guid id)
        {
            return await _contactService.FindAsync(id);
        }

        // POST api/<ContactController>
        [HttpPost]
        public async void Post([FromBody] Contact value)
        {
            await _contactService.AddAsync(value);
        }

        // PUT api/<ContactController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody] Contact value)
        {
            await _contactService.UpdateAsync(value, id);
        }

        // DELETE api/<ContactController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _contactService.SoftDeleteAsync(id);
        }
    }
}
