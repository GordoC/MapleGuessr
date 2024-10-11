using server.Dtos;
using server.Models;

namespace server.Mappers
{
    public static class MapMappers
    {
        public static MapDto ToMapDto(this Map mapModel)
        {
            return new MapDto
            {
                Id = mapModel.Id,
                Name = mapModel.Name,
                StreetName = mapModel.StreetName,
                Image = mapModel.Image,
                RegionId = mapModel.RegionId
            };
        }
    }
}