using Microsoft.EntityFrameworkCore;
using SecretSanta.Models;

namespace SecretSanta.Data
{
    public class SecretSantaDbContext : DbContext
    {
        public SecretSantaDbContext(DbContextOptions<SecretSantaDbContext> options) :
            base(options)
        { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Gift>(entity =>
            {
                entity.Property(g => g.ID).ValueGeneratedOnAdd();

            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.Property(g => g.ID).ValueGeneratedOnAdd();

            });
        }

        public DbSet<Gift> Gifts => Set<Gift>();
        public DbSet<Group> Groups => Set<Group>();
    }
}
