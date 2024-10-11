using Microsoft.AspNetCore.Mvc;
using server.Interfaces;
using server.Mappers;

namespace server.Controllers
{
    [Route("server/region")]
    [ApiController]
    public class RegionController : ControllerBase
    {
        private readonly IRegionRepository _regionRepository;
        public RegionController(IRegionRepository regionRepository)
        {
            _regionRepository = regionRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var regions = await _regionRepository.GetAllAsync();

            var regionsDto = regions.Select(r => r.ToRegionDto());

            return Ok(regionsDto);
        }

<<<<<<< HEAD
        [HttpGet("{id:int}")]
=======
        [HttpGet("{id}")]
>>>>>>> c748a68f1151d441f9ab9133f516380b9dbac3d1
        public async Task<IActionResult> GetById([FromRoute] int id)
        {
            var region = await _regionRepository.GetByIdAsync(id);

            return region == null ? NotFound() : Ok(region.ToRegionDto());
        }
    }
}