using BRSK.Models;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace BRSK.Data
{
    public class BRSKApplicationContext : DbContext
    {

        public BRSKApplicationContext(DbContextOptions<BRSKApplicationContext> options) : base(options)
        {
            
                //Database.EnsureCreated();
            
        }
        public DbSet<Model> Models { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<Model>().HasData(
           //         new Model[]
           //     {
           // new Model{ModelId=1,BrandId=1,Name="Toyota Corolla",Activity=true},
           // new Model{ModelId=2,BrandId=1,Name="Toyota Land Cruiser",Activity=true},
           // new Model{ModelId=3,BrandId=1,Name="Toyota Camry",Activity=true},
           // new Model{ModelId=4,BrandId=2,Name="BMW x2",Activity=true},
           // new Model{ModelId=5,BrandId=2,Name="BMW x5",Activity=true},
           // new Model{ModelId=6,BrandId=2,Name="BMW x6",Activity=true},
           // new Model{ModelId=7,BrandId=3,Name="Lada Vesta",Activity=true},
           // new Model{ModelId=8,BrandId=3,Name="Lada Granta",Activity=true},
           // new Model{ModelId=9,BrandId=3,Name="Lada Largus",Activity=true},
           // new Model{ModelId=10,BrandId=4,Name="Mersedes Benz",Activity=true},
           // new Model{ModelId=11,BrandId=4,Name="Mersedes 2000",Activity=true},
           // new Model{ModelId=12,BrandId=4,Name="Mersedes 1000",Activity=true},
           // new Model{ModelId=13,BrandId=5,Name="Volvo S60",Activity=true},
           // new Model{ModelId=14,BrandId=5,Name="Volvo 700",Activity=true},
           // new Model{ModelId=15,BrandId=5,Name="Volvo s80",Activity=true},
           // new Model{ModelId=16,BrandId=6,Name="Miscubishi Pajero",Activity=true},
           // new Model{ModelId=17,BrandId=6,Name="Miscubishi Delica",Activity=true},
           // new Model{ModelId=18,BrandId=6,Name="Miscubishi Lancer",Activity=true},
           // new Model{ModelId=19,BrandId=7,Name="Audi v6",Activity=true},
           // new Model{ModelId=20,BrandId=7,Name="Audi A1",Activity=true},
           // new Model{ModelId=21,BrandId=7,Name="Audi A3",Activity=true},
           // new Model{ModelId=22,BrandId=8,Name="Vaz 2106",Activity=true},
           // new Model{ModelId=23,BrandId=8,Name="Vaz 2101",Activity=true},
           // new Model{ModelId=24,BrandId=8,Name="Zhiguly",Activity=true}
           //     }
           //     );

           //modelBuilder.Entity<Brand>().HasData(
           //   new Brand[]
           // {
           // new Brand{BrandId=1,Name="Toyota",Activity=true},
           // new Brand{BrandId=2,Name="BMW",Activity=true},
           // new Brand{BrandId=3,Name="Lada",Activity=true},
           // new Brand{BrandId=4,Name="Mersedes",Activity=true},
           // new Brand{BrandId=5,Name="Volvo",Activity=true},
           // new Brand{BrandId=6,Name="Miscubishi",Activity=true},
           // new Brand{BrandId=7,Name="Audi",Activity=true},
           // new Brand{BrandId=8,Name="Vaz",Activity=true}
           // });

        }
    }
}
    

