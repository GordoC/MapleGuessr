using server.Models;

namespace server.Dtos
{
    public class RegionDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
<<<<<<< HEAD
=======
        public ICollection<Map> Maps { get; set; } = new HashSet<Map>();
>>>>>>> c748a68f1151d441f9ab9133f516380b9dbac3d1
        public int? WorldId { get; set; }
    }
}