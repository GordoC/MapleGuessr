using Microsoft.AspNetCore.Mvc;
using server.Data;

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
        public IActionResult GetAll()
        {
            var maps = _context.Maps.ToList();

            return Ok(maps);
        }

        [HttpGet("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            var map = _context.Maps.Find(id);

            return map == null ? NotFound() : Ok(map);
        }
    }
}