namespace server.Models
{
    public class World
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Region> Regions { get; set; } = new HashSet<Region>();
    }
}