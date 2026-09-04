using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace ZombieParty.Models.Data
{
    public class ZombiePartyDbContext : DbContext
    {

        public ZombiePartyDbContext(DbContextOptions<ZombiePartyDbContext>options):base(options)
        {

        }

        public DbSet<Zombie> zombies { get; set; }
        public DbSet<ZombieType> ZombieTypes { get; set; }

    }
}
