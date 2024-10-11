using server.Models;

namespace server.Interfaces
{
    public interface IMapRepository
    {
        Task<List<Map>> GetAllAsync();
        Task<Map?> GetByIdAsync(int id);
    }
}