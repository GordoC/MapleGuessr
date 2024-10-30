using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using server.Models;

namespace server.Data
{
    public class ApplicationDBContext : IdentityDbContext<User>
    {
        public ApplicationDBContext(DbContextOptions dbContextOptions) 
        : base(dbContextOptions) 
        {
            
        }

        public DbSet<Map> Maps { get; set; }
        public DbSet<Region> Regions { get; set; }
        public DbSet<World> Worlds { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            base.OnModelCreating(modelBuilder);

            List<IdentityRole> roles = new List<IdentityRole>
            {
                new IdentityRole { Name = "Admin", NormalizedName = "ADMIN" },
                new IdentityRole { Name = "User", NormalizedName = "USER" }
            };
            modelBuilder.Entity<IdentityRole>().HasData(roles);

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