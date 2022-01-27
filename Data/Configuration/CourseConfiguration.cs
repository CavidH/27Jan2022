using System;
using System.Collections.Generic;
using System.Text;
using Core.Entitiy;
using Microsoft.EntityFrameworkCore;
 
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Data.Configuration
{
    class CourseConfiguration : IEntityTypeConfiguration<Course>
    {
        public void Configure(EntityTypeBuilder<Course> builder)
        {
            builder.Property(p => p.Name).IsRequired().HasMaxLength(255);
            builder.Property(p => p.AuthorName).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Category).IsRequired().HasMaxLength(255);
            builder.Property(p => p.Content).IsRequired().HasMaxLength(255);
            builder.Property(p => p.AuthorImage).IsRequired();
            builder.Property(p => p.CoverImage).IsRequired();

        }
    }
}
