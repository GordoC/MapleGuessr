namespace server.Models
{
    public class Region
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public ICollection<Map> Maps { get; set; } = new HashSet<Map>();
        /// <summary>
        /// Foreign key to the parent entity (World)
        /// </summary>
        public int? WorldId { get; set; }
        /// <summary>
        /// Navigation property back to the parent entity (World)
        /// </summary>
        public World? World { get; set; }
    }
}