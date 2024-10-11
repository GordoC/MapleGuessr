using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Interfaces;
using server.Models;

namespace server.Repository
{
    public class WorldRepository : IWorldRepository
    {
        private readonly ApplicationDBContext _context;
        public WorldRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<World>> GetAllAsync()
        {
            return await _context.Worlds.ToListAsync();
        }

        public async Task<World?> GetByIdAsync(int id)
        {
            return await _context.Worlds.FindAsync(id);
        }
    }
}