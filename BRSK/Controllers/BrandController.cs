using BRSK.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using BRSK.Models;

namespace BRSK.Controllers
{
    public class BrandController:Controller
    {

        private BRSKApplicationContext _context;
        public BrandController(BRSKApplicationContext context)
        {
            _context = context;

        }


        public async Task<IActionResult> Index()
        {
            return View(await _context.Brands.AsQueryable().ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Brand newbrand)
        {
           
            _context.Brands.Add(newbrand);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
       
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Brand brand = await _context.Brands.FirstOrDefaultAsync(brandItem => brandItem.BrandId == id);
                if (brand != null)
                    return View(brand);
            }
            return NotFound();
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Brand Brand)
        {
            _context.Brands.Update(Brand);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        [HttpGet]
        [ActionName("Delete")]
        public async Task<IActionResult> ConfirmDelete(int? id)
        {
            if (id != null)
            {
                Brand brand = await _context.Brands.FirstOrDefaultAsync(brandItem => brandItem.BrandId == id);
                if (brand != null)
                    return View(brand);
            }
            return NotFound();
        }

        [HttpPost]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id != null)
            {
                Brand brand = await _context.Brands.FirstOrDefaultAsync(brandItem => brandItem.BrandId == id);
                if (brand != null)
                {
                    _context.Brands.Remove(brand);
                    await _context.SaveChangesAsync();
                    return RedirectToAction("Index");
                }
            }
            return NotFound();
        }
    }
}
