using Microsoft.EntityFrameworkCore;

namespace PubgStats.AppCore.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() { }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
    }
}
