using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Core.Entitiy;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace Data.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) :base(options)
        {
        }

        public Course Courses { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(Course).Assembly);
        }
    }
}
