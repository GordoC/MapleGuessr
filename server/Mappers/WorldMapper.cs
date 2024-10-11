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
<<<<<<< HEAD
                Name = worldModel.Name
=======
                Name = worldModel.Name,
                Regions = worldModel.Regions
>>>>>>> c748a68f1151d441f9ab9133f516380b9dbac3d1
            };
        }
    }
}