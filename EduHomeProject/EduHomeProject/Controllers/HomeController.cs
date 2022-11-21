using EduHomeProject.DAL;
using EduHomeProject.Models;
using EduHomeProject.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _db;
        public HomeController(AppDbContext db)
        {
            _db = db;
        }
        public async Task<IActionResult> Index()
        {
            
            HomeVM homeVM = new HomeVM
            {
                Sliders= await _db.Sliders.Where(x => !x.IsDeactive).ToListAsync(),
                About=await _db.Abouts.FirstAsync(),
                Services =await _db.Services.Where(x=> !x.IsDeactive).ToListAsync(),
                Courses =await _db.Courses.ToListAsync(),
                Blog =await _db.Blog.ToListAsync(),
                Notice =await _db.Notice.ToListAsync(),
                Events =await _db.Events.ToListAsync()
                
        };
            return View(homeVM);
        }


        public IActionResult Error()
        {
            return View();
        }
    }
}
