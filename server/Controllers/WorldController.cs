using Microsoft.AspNetCore.Mvc;
using server.Interfaces;
using server.Mappers;

namespace server.Controllers
{
    [Route("server/world")]
    [ApiController]
    public class WorldController : ControllerBase
    {
        private readonly IWorldRepository _worldRepository;
        public WorldController(IWorldRepository worldRepository)
        {
            _worldRepository = worldRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var worlds = await _worldRepository.GetAllAsync();

            var worldsDto = worlds.Select(r => r.ToWorldDto());

            return Ok(worldsDto);
        }

<<<<<<< HEAD
        [HttpGet("{id:int}")]
=======
        [HttpGet("{id}")]
>>>>>>> c748a68f1151d441f9ab9133f516380b9dbac3d1
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var world = await _worldRepository.GetByIdAsync(id);

            return world == null ? NotFound() : Ok(world.ToWorldDto());
        }
    }
}