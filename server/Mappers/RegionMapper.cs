using server.Dtos;
using server.Models;

namespace server.Mappers
{
    public static class RegionMapper
    {
        public static RegionDto ToRegionDto(this Region regionModel)
        {
            return new RegionDto
            {
                Id = regionModel.Id,
                Name = regionModel.Name,
                WorldId = regionModel.WorldId
            };
        }
    }
}