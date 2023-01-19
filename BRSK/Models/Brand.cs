using System.Collections.Generic;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BRSK.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Activity { get; set; } = true;
        public List<Model> BrandModels { get; set; }
        public Brand()
        {
            BrandModels = new List<Model>();
        }
    }
}
