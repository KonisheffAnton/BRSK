using BRSK.Data;
using BRSK.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            return View(await _context.Models.ToListAsync());
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Model model)
        {
            _context.Models.Add(model);
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Details(int? id)
        {
            if (id != null)
            {
                Model model = await _context.Models.FirstOrDefaultAsync(modelItem => modelItem.Id == id);
                if (model != null)
                    return View(model);
            }
            return NotFound();
        }
        public async Task<IActionResult> Edit(int? id)
        {
            if (id != null)
            {
                Model model = await _context.Models.FirstOrDefaultAsync(modelItem => modelItem.Id == id);
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
                Model model = await _context.Models.FirstOrDefaultAsync(modelItem => modelItem.Id == id);
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
                Model model = await _context.Models.FirstOrDefaultAsync(p => p.Id == id);
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
