using ahmad.Models;
using Microsoft.EntityFrameworkCore;

namespace ahmad.Persistence
{
    public class AhmadDbContext:DbContext
    {
         public DbSet<Make> makes { get; set; }
        public DbSet<Feature> Features {get; set;}
   public AhmadDbContext(DbContextOptions<AhmadDbContext> options)
        :base(options)
        {
            
        }
       protected override void OnModelCreating(ModelBuilder modelBuilder){

           modelBuilder.Entity<VehincleFeature>().HasKey(vf => new {vf.VehincleId , vf.FeatureId});

       }
        
    }
}