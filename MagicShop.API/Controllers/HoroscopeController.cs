using MagicShop.Kernel.Entities;
using MagicShop.Process.Abstract;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MagicShop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HoroscopeController : ControllerBase
    {
        private readonly IHoroscopeService _horoscopeService;

        public HoroscopeController(IHoroscopeService horoscopeService)
        {
            _horoscopeService = horoscopeService;
        }

        // GET: api/<HoroscopeController>
        [HttpGet]
        public async Task<IEnumerable<Horoscope>> Get()
        {
            return await _horoscopeService.GetHoroscopesByIncludeAsync();
        }

        // GET api/<HoroscopeController>/5
        [HttpGet("{id}")]
        public async Task<Horoscope> Get(Guid id)
        {
            return await _horoscopeService.GetHoroscopeByIncludeAsync(id);
        }

        // POST api/<HoroscopeController>
        [HttpPost]
        public async void Post([FromBody] Horoscope value)
        {
            await _horoscopeService.AddAsync(value);
        }

        // PUT api/<HoroscopeController>/5
        [HttpPut("{id}")]
        public async void Put(Guid id, [FromBody] Horoscope value)
        {
            await _horoscopeService.UpdateAsync(value, id);
        }

        // DELETE api/<HoroscopeController>/5
        [HttpDelete("{id}")]
        public async void Delete(Guid id)
        {
            await _horoscopeService.SoftDeleteAsync(id);
        }
    }
}
