using server.Dtos;
using server.Models;

namespace server.Mappers
{
    public static class WorldMapper
    {
        public static WorldDto ToWorldDto(this World worldModel)
        {
            return new WorldDto
            {
                Id = worldModel.Id,
                Name = worldModel.Name,
                Regions = worldModel.Regions
            };
        }
    }
}