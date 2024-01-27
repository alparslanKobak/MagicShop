using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AppUserController : ControllerBase
    {
        private readonly IAppUserService _appUserService;

        public AppUserController(IAppUserService appUserService)
        {
            _appUserService = appUserService;
        }

        // GET: api/<AppUserController>
        [HttpGet]
        public async Task<IEnumerable<AppUser>> Get()
        {
            return await _appUserService.GetAppUsersByIncludeAsync();
        }

        // GET api/<AppUserController>/5
        [HttpGet("{id}")]
        public async Task<AppUser> Get(Guid id)
        {
            return await _appUserService.GetAppUserByIncludeAsync(id);
        }

        // POST api/<AppUserController>
        [HttpPost]
        public void Post([FromBody] AppUser value)
        {
        }

        // PUT api/<AppUserController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<AppUserController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
