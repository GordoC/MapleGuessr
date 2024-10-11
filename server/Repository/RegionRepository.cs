using Microsoft.EntityFrameworkCore;
using server.Data;
using server.Interfaces;
using server.Models;

namespace server.Repository
{
    public class RegionRepository : IRegionRepository
    {
        private readonly ApplicationDBContext _context;
        public RegionRepository(ApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<List<Region>> GetAllAsync()
        {
            return await _context.Regions.ToListAsync();
        }

        public async Task<Region?> GetByIdAsync(int id)
        {
            return await _context.Regions.FindAsync(id);
        }
    }
}