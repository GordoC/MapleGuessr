namespace server.Dtos
{
    public class MapDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        /// <summary>
        /// Name of the street (a street contains multiple maps)
        /// </summary>
        public string StreetName { get; set; } = string.Empty;
        public string Image { get; set; } = string.Empty;
    }
}