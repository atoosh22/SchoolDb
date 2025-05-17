using dashboard.Models;
using Microsoft.EntityFrameworkCore;

namespace dashboard.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<LevelModel> Levels { get; set; }
    }
}