using server.Models;

namespace server.Dtos
{
    public class RegionDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Map> Maps { get; set; } = new HashSet<Map>();
        public int? WorldId { get; set; }
    }
}