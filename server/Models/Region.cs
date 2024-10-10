namespace server.Models
{
    public class Region
    {
        private int Id { get; set; }
        private string Name { get; set; } = string.Empty;
        private HashSet<Map> Maps { get; set; } = new HashSet<Map>();
    }
}