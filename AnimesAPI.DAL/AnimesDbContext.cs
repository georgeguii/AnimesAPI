using AnimesAPI.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnimesAPI.DAL
{
    public class AnimesDbContext : DbContext
    {
        public DbSet<Anime> Usuarios { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                string? connectionString = Environment.GetEnvironmentVariable("ANIMES_CONNECTION_STRING");
                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
