using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BRSK.Models
{
    public class Model
    {
        public int ModelId { get; set; }
        public int BrandId { get; set; } = 1;
        public string Name { get; set; }
        public bool Activity { get; set; } = false;

        public Brand Brand { get; set; }
    }
}
