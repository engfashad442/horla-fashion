using ahmad.Models;
using Microsoft.EntityFrameworkCore;

namespace ahmad.Persistence
{
    public class AhmadDbContext:DbContext
    {
        public AhmadDbContext(DbContextOptions<AhmadDbContext> options)
        :base(options)
        {
            
        }
        public DbSet<Make> makes { get; set; }
        
    }
}