using server.Models;

namespace server.Dtos
{
    public class WorldDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
<<<<<<< HEAD
=======
        public ICollection<Region> Regions { get; set; } = new HashSet<Region>();
>>>>>>> c748a68f1151d441f9ab9133f516380b9dbac3d1
    }
}