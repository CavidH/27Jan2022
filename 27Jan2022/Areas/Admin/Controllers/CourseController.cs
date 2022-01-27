using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using _27Jan2022.Areas.Admin.ViewModels;
using Core.Entitiy;
using Data.DAL;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace _27Jan2022.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CourseController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public CourseController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }

       
        public async Task<IActionResult> Index()
        {

            var courses = await _context.Courses.ToListAsync();
            return View(courses);
        }
         public async Task<IActionResult> Create()
        {

            return View();
        }
         public async Task<IActionResult> Delete(int Id)
         {
             var courses = await _context.Courses.FindAsync(Id);
             _context.Remove(courses);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }

        [HttpPost]
         public async Task<IActionResult> Create(CourseVM courseVm)
         {
             if (ModelState.IsValid)
             {
                 string AuthorImageName = ProcessUploadedFile(courseVm.AuthorImageFile);
                 string CoverImageName = ProcessUploadedFile(courseVm.CoverImageFile);
                 var course = new Course
                 {
                     Name = courseVm.Name,
                     Category = courseVm.Category,
                     Content = courseVm.Content,
                     AuthorName = courseVm.AuthorName,
                     AuthorImage = AuthorImageName,
                     CoverImage = CoverImageName,
                     
                     
                 };
                await _context.AddAsync(course);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
                //Speaker speaker = new Speaker
                //{
                //    SpeakerName = model.SpeakerName,
                //    Qualification = model.Qualification,
                //    Experience = model.Experience,
                //    SpeakingDate = model.SpeakingDate,
                //    SpeakingTime = model.SpeakingTime,
                //    Venue = model.Venue,
                //    ProfilePicture = uniqueFileName
                //};

                //db.Add(speaker);
                //await db.SaveChangesAsync();

            }
             return View(courseVm);


        }

         private string ProcessUploadedFile(IFormFile image)
         {
            
             string uniqueFileName = null;

             if (image != null)
             {
                 string uploadsFolder = Path.Combine(_env.WebRootPath, "assets","Upload");
                 uniqueFileName = Guid.NewGuid().ToString() + "_" + image.FileName;
                 string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                 using (var fileStream = new FileStream(filePath, FileMode.Create))
                 {
                     image.CopyTo(fileStream);
                 }
             }

             return uniqueFileName;
         }
    }
}
