using BRSK.Models;
using Microsoft.EntityFrameworkCore;

namespace BRSK.Data
{
    public class BRSKApplicationContext:DbContext
    {
        public DbSet<Model> Models { get; set; }
        public BRSKApplicationContext(DbContextOptions<BRSKApplicationContext> options): base(options)
        {
            Database.EnsureCreated();   
        }
    }
}
