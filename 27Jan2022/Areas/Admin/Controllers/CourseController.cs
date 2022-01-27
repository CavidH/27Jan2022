using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Data.DAL;
using Microsoft.EntityFrameworkCore;

namespace _27Jan2022.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;

        public CourseController(AppDbContext context)
        {
            _context = context;
        }

       
        public async Task<IActionResult> Index()
        {

            var courses = await _context.Courses.ToListAsync();
            return View(courses);
        }
    }
}
