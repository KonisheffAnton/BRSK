using BRSK.Models;
using System.Linq;

namespace BRSK.Data
{
    public class DbInitializer
    {
        public static void Initialize(BRSKApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (!context.Brands.Any())
            {
                var brands = new Brand[]
               {
            new Brand{Name="Toyota",Activity=true},
            new Brand{Name="BMW",Activity=true},
            new Brand{Name="Lada",Activity=true},
            new Brand{Name="Mersedes",Activity=true},
            new Brand{Name="Volvo",Activity=true},
            new Brand{Name="Miscubishi",Activity=true},
            new Brand{Name="Audi",Activity=true},
            new Brand{Name="Vaz",Activity=true}
               };
                foreach (Brand item in brands)
                {
                    context.Brands.Add(item);
                }
                context.SaveChanges();
            }
            if (!context.Models.Any())
            {
                {
                    var models = new Model[]
               {
            new Model{BrandId=1,Name="Toyota Corolla",Activity=true},
            new Model{BrandId=1,Name="Toyota Land Cruiser",Activity=true},
            new Model{BrandId=1,Name="Toyota Camry",Activity=true},
            new Model{BrandId=2,Name="BMW x2",Activity=true},
            new Model{BrandId=2,Name="BMW x5",Activity=true},
            new Model{BrandId=2,Name="BMW x6",Activity=true},
            new Model{BrandId=3,Name="Lada Vesta",Activity=true},
            new Model{BrandId=3,Name="Lada Granta",Activity=true},
            new Model{BrandId=3,Name="Lada Largus",Activity=true},
            new Model{BrandId=4,Name="Mersedes Benz",Activity=true},
            new Model{BrandId=4,Name="Mersedes 2000",Activity=true},
            new Model{BrandId=4,Name="Mersedes 1000",Activity=true},
            new Model{BrandId=5,Name="Volvo S60",Activity=true},
            new Model{BrandId=5,Name="Volvo 700",Activity=true},
            new Model{BrandId=5,Name="Volvo s80",Activity=true},
            new Model{BrandId=6,Name="Miscubishi Pajero",Activity=true},
            new Model{BrandId=6,Name="Miscubishi Delica",Activity=true},
            new Model{BrandId=6,Name="Miscubishi Lancer",Activity=true},
            new Model{BrandId=7,Name="Audi v6",Activity=true},
            new Model{BrandId=7,Name="Audi A1",Activity=true},
            new Model{BrandId=7,Name="Audi A3",Activity=true},
            new Model{BrandId=8,Name="Vaz 2106",Activity=true},
            new Model{BrandId=8,Name="Vaz 2101",Activity=true},
            new Model{BrandId=8,Name="Zhiguly",Activity=true}

               };
                    foreach (Model item in models)
                    {
                        context.Models.Add(item);
                    }
                    context.SaveChanges();
                }
            }
        }
    }
}
