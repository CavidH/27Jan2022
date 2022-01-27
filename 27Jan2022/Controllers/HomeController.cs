using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using _27Jan2022.ViewModels;
using Data.DAL;
using Microsoft.EntityFrameworkCore;

namespace _27Jan2022.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            var courses = await _context.Courses.ToListAsync();
            var homeVM = new HomeVM
            {
                Courses = courses
            };
            return View(homeVM);
        }

       



    }
}
