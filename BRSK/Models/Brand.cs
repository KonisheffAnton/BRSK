using System.Collections.Generic;
using System.Collections.ObjectModel;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BRSK.Models
{
    public class Brand
    {
        public int BrandId { get; set; }
        public string Name { get; set; }
        public bool Activity { get; set; } = false;
        public ICollection<Model> BrandModels { get; set; }
        public Brand()
        {
            BrandModels = new Collection<Model>();
        }
    }
}
