using server.Models;

namespace server.Interfaces
{
    public interface IWorldRepository
    {
        Task<List<World>> GetAllAsync();
        Task<World?> GetByIdAsync(int id);
    }
}