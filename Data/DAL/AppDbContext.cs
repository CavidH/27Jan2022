using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Core.Entitiy;
using Data.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Data.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Course>().HasData(
                new Course
                {
                    Id = 1,
                    Name = "sdfsdf",
                    Category = "asdasd",
                    Content = "asdasd",
                    CoverImage = "course-1.jpg",
                    AuthorName = "Asdasd",
                    AuthorImage = "trainer-1.jpg"
                }
                , new Course
                {
                    Id = 2,
                    Name = "sdfsdf",
                    Category = "asdasd",
                    Content = "asdasd",
                    CoverImage = "course-1.jpg",
                    AuthorName = "Asdasd",
                    AuthorImage = "trainer-1.jpg"
                }, new Course
                {
                    Id = 3,
                    Name = "sdfsdf",
                    Category = "asdasd",
                    Content = "asdasd",
                    CoverImage = "course-1.jpg",
                    AuthorName = "Asdasd",
                    AuthorImage = "trainer-1.jpg"
                });
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Course).Assembly);
        }
        public DbSet<Course> Courses { get; set; }
    }
}
