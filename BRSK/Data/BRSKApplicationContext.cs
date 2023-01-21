using BRSK.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BRSK.Data
{
    public class BRSKApplicationContext : DbContext
    {

        public BRSKApplicationContext(DbContextOptions<BRSKApplicationContext> options) : base(options)
        {
            
        }
        public DbSet<Model> Models { get; set; }
        public DbSet<Brand> Brands { get; set; }
    }
}
    

