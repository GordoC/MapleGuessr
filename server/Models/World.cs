namespace server.Models
{
    public class World
    {
        private int Id { get; set; }
        private string Name { get; set; } = string.Empty;
        private HashSet<Region> Regions { get; set; } = new HashSet<Region>();
    }
}