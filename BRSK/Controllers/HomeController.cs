using BRSK.Data;
using BRSK.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace BRSK.Controllers
{
    public class HomeController : Controller
    {

        private BRSKApplicationContext _context;
        public HomeController(BRSKApplicationContext context)
        {
            _context = context;

        }



        public async Task<IActionResult> Index()
        {
            var ModelList = await _context.Models.AsQueryable().Include(modelItem => modelItem.Brand).ToListAsync();
            return View(ModelList.OrderBy(item => item.Brand.Name).ToList());
        }
        
    }
}
