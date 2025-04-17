using Microsoft.EntityFrameworkCore;
namespace BloodDonar1.Models
{
    public class BloodDbContext:DbContext
    {
        public BloodDbContext(DbContextOptions<BloodDbContext> options) : base(options)
        {

        }
        public DbSet<Bloods> BloodDonar1s { get; set; } 

    }
}
