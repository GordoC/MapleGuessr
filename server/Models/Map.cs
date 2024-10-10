namespace server.Models
{
    public class Map
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string StreetName { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        /// <summary>
        /// // Foreign key to the parent entity (Region)
        /// </summary>
        public int? RegionId { get; set; }
        /// <summary>
        /// Navigation property back to the parent entity (Region)
        /// </summary>
        public Region? Region { get; set; }
    }
}