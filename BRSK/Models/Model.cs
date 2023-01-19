using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace BRSK.Models
{
    public class Model
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Activity { get; set; } = false;
    }
}
