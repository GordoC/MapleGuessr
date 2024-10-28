using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Interfaces;
using server.Models;

namespace server
{
    public class MapRepository : IMapRepository
    {
        private readonly ApplicationDBContext _context;
        public MapRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Map>> GetAllAsync()
        {
            return await _context.Maps.ToListAsync();
        }

        public async Task<Map?> GetByIdAsync(int id)
        {
            return await _context.Maps.FindAsync(id);
        }

        public async Task<Map?> GetByGameIdAsync(int gameId)
        {
            return await _context.Maps
                                 .FirstOrDefaultAsync(region => region.GameId == gameId);
        }
    }
}