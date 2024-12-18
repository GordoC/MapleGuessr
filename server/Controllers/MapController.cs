using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using server.Interfaces;
using server.Mappers;

namespace server.Controllers
{
    [Route("server/map")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly IMapRepository _mapRepository;
        public MapController(IMapRepository mapRepository)
        {
            _mapRepository = mapRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var maps = await _mapRepository.GetAllAsync();

            var mapsDto = maps.Select(m => m.ToMapDto());

            return Ok(mapsDto);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var map = await _mapRepository.GetByIdAsync(id);

            return map == null ? NotFound() : Ok(map.ToMapDto());
        }

        [HttpGet("gameId/{gameId:int}")]
        public async Task<IActionResult> GetByGameId([FromRoute] int gameId)
        {
            var map = await _mapRepository.GetByGameIdAsync(gameId);

            return map == null ? NotFound() : Ok(map.ToMapDto());
        }
    }
}