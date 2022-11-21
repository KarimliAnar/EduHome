using EduHomeProject.DAL;
using EduHomeProject.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EduHomeProject.Controllers
{
    public class CoursesController : Controller

    {
        private readonly AppDbContext _db;
       

        public CoursesController(AppDbContext db)
        {
            _db = db;
        }
        public async Task <IActionResult> Index()
        {
            ViewBag.CourseCount = _db.Course.Count();
            List<Course> course = await _db.Course.OrderByDescending(x=>x.Id).Take(6).ToListAsync();
            return View(course);
        }
        public async Task<IActionResult>LoadMoreAsync(int skip)
        {
            if (_db.Course.Count() <= skip)
            {
                return Content("enough");
            }
            List<Course> course = await _db.Course.OrderByDescending(x => x.Id).Skip(skip).Take(6).ToListAsync();
            return PartialView("_LoadMoreCoursesPartial", course);
        }
    }
}
