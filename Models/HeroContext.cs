using Microsoft.EntityFrameworkCore;

namespace PersonasApi.Models
{
    public class HeroContext : DbContext
    {
        public HeroContext(DbContextOptions<HeroContext> options)
            : base(options)
        {

        }

        public DbSet<Hero> Hero { get; set; }

        public DbSet<Home> Home { get; set; }

    }
}
