using BRSK.Models;
using System.Linq;

namespace BRSK.Data
{
    public class DbInitializer
    {
        public static void Initialize(BRSKApplicationContext context)
        {
            context.Database.EnsureCreated();

            if (context.Models.Any())
            {
                var models = new Model[]
           {
            new Model{BrandId=1,Name="Toyota",Activity=true},
            new Model{BrandId=1,Name="Toyota",Activity=true},
            new Model{BrandId=1,Name="Toyota",Activity=true},
            new Model{BrandId=2,Name="BMW",Activity=true},
            new Model{BrandId=2,Name="BMW",Activity=true},
            new Model{BrandId=2,Name="BMW",Activity=true},
            new Model{BrandId=3,Name="Lada",Activity=true},
            new Model{BrandId=3,Name="Lada",Activity=true},
            new Model{BrandId=3,Name="Lada",Activity=true},
            new Model{BrandId=4,Name="Mersedes",Activity=true},
            new Model{BrandId=4,Name="Mersedes",Activity=true},
            new Model{BrandId=4,Name="Mersedes",Activity=true},
            new Model{BrandId=5,Name="Volvo",Activity=true},
            new Model{BrandId=5,Name="Volvo",Activity=true},
            new Model{BrandId=5,Name="Volvo",Activity=true},
            new Model{BrandId=6,Name="Miscubishi",Activity=true},
            new Model{BrandId=6,Name="Miscubishi",Activity=true},
            new Model{BrandId=6,Name="Miscubishi",Activity=true},
            new Model{BrandId=7,Name="Audi",Activity=true},
            new Model{BrandId=7,Name="Audi",Activity=true},
            new Model{BrandId=7,Name="Audi",Activity=true},
            new Model{BrandId=8,Name="Vaz",Activity=true},
            new Model{BrandId=8,Name="Audi",Activity=true},
            new Model{BrandId=8,Name="Audi",Activity=true}

           };
                foreach (Model item in models)
                {
                    context.Models.Add(item);
                }
                context.SaveChanges();

                var brands = new Brand[]
                {
            new Brand{BrandId=1,Name="Chemistry",Activity=true},
            new Brand{BrandId=2,Name="Chemistry",Activity=true},
            new Brand{BrandId=3,Name="Chemistry",Activity=true},
            new Brand{BrandId=4,Name="Chemistry",Activity=true},
            new Brand{BrandId=5,Name="Chemistry",Activity=true},
            new Brand{BrandId=6,Name="Chemistry",Activity=true},
            new Brand{BrandId=7,Name="Chemistry",Activity=true},
            new Brand{BrandId=8,Name="Chemistry",Activity=true}
                };
                foreach (Brand item in brands)
                {
                    context.Brands.Add(item);
                }
                context.SaveChanges();
            }
        }
    }
}
