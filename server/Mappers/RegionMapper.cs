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
<<<<<<< HEAD
=======
                Maps = regionModel.Maps,
>>>>>>> c748a68f1151d441f9ab9133f516380b9dbac3d1
                WorldId = regionModel.WorldId
            };
        }
    }
}