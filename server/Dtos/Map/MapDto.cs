namespace server.Dtos
{
    public class MapDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string StreetName { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
        public int? RegionId { get; set; }
        public int? GameId { get; set; }
    }
}