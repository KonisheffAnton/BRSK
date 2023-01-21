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
        //public async Task<IActionResult> Create()
        //{
        //    return View(new PageModel { BrandList = new SelectList(await _context.Brands.ToListAsync(), "BrandId", "Name") });
        //}
        //[HttpPost]
        //public async Task<IActionResult> Create(PageModel pagemodel)
        //{
        //    var model = new Model()
        //    {
        //        BrandId = pagemodel.SelectedBrand+1,
        //        Name = pagemodel.ModelName,
        //        Activity = pagemodel.Activity
        //    };
        //    _context.Models.Add(model);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction("Index");
        //}
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Model model = await _context.Models.FirstOrDefaultAsync(modelItem => modelItem.ModelId == id);
                if (model != null)
                    return View(model);
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Model model = await _context.Models.FirstOrDefaultAsync(modelItem => modelItem.ModelId == id);
                if (model != null)
                    return View(model);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Model model)
        {
            _context.Models.Update(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Model model = await _context.Models.FirstOrDefaultAsync(modelItem => modelItem.ModelId == id);
                if (model != null)
                    return View(model);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Model model = await _context.Models.FirstOrDefaultAsync(modelItem => modelItem.ModelId == id);
                if (model != null)
                {
                    _context.Models.Remove(model);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
