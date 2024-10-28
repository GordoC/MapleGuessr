using server.Models;

namespace server.Interfaces
{
    public interface IRegionRepository
    {
        Task<List<Region>> GetAllAsync();
        Task<Region?> GetByIdAsync(int id);
        Task<Region?> GetByGameIdAsync(int gameId);
    }
}