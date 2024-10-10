using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) 
        : base(dbContextOptions) {
            
        }

        public DbSet<Map> Map { get; set; }
        public DbSet<Region> Region { get; set; }
        public DbSet<World> World { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Region>()
                .HasMany(r => r.Maps)
                .WithOne(m => m.Region)
                .HasForeignKey(m => m.RegionId);

            modelBuilder.Entity<World>()
                .HasMany(w => w.Regions)
                .WithOne(r => r.World)
                .HasForeignKey(r => r.WorldId);
        }
    }
}