using EduHomeProject.DAL;
using EduHomeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServicesController : Controller
    {
        private readonly AppDbContext _db;
      

        public ServicesController(AppDbContext db)
        {
            _db = db;

        }
        public async Task<IActionResult> Index()
        {

            List<Services> services = await _db.Services.ToListAsync();
            return View(services);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Services services)

        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            bool isExist = await _db.Services.AnyAsync(x => x.Title == services.Title);
            if (isExist)
            {
                ModelState.AddModelError("Title", "This service is already exists");
                return View();
            }
            await _db.Services.AddAsync(services);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Services services = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (services == null)
            {
                return BadRequest();
            }
            return View(services);
        }
        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeletePost(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Services services = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (services == null)
            {
                return BadRequest();
            }
            services.IsDeactive = true;
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }

        public async Task<IActionResult> ActivityAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Services services = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (services == null)
            {
                return BadRequest();
            }
            if (services.IsDeactive)
            {
                services.IsDeactive = false;
            }
            else
            {
                services.IsDeactive = true;
            }
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public IActionResult Detail()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Detail(Services services)

        {

            await _db.Services.AddAsync(services);
            await _db.SaveChangesAsync();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Update(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            Services services = await _db.Services.FirstOrDefaultAsync(x => x.Id == id);
            if (services == null)
            {
                return BadRequest();
            }
            return View(services);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Update(int? id,Services services)
        {
            if (id == null)
            {
                return NotFound();
            }
            Services dbServices = await _db.Services.FirstOrDefaultAsync(x=>x.Id==id);
            if (dbServices == null)
            {
                return BadRequest();
            }

            if (!ModelState.IsValid)
            {
                return View(dbServices);
            }
            bool isExist = await _db.Services.AnyAsync(x => x.Title == services.Title&&x.Id!=id);
            if (isExist)
            {
                ModelState.AddModelError("Title", "This service is already exists");
                return View(dbServices);
            }
            dbServices.Title = services.Title;
            dbServices.Description = services.Description;
            await _db.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }


    }
}
