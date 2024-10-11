using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Mappers;

namespace server.Controllers
{
    [Route("server/map")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly ApplicationDBContext _context;
        public MapController(ApplicationDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var maps = await _context.Maps.ToListAsync();

            var mapsDto = maps.Select(m => m.ToMapDto());

            return Ok(mapsDto);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var map = await _context.Maps.FindAsync(id);

            return map == null ? NotFound() : Ok(map.ToMapDto());
        }
    }
}