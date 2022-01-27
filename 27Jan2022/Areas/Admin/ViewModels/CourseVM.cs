using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace _27Jan2022.Areas.Admin.ViewModels
{
    public class CourseVM
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        [NotMapped]
        public IFormFile CoverImageFile { get; set; }
        public string AuthorName { get; set; }
        [NotMapped]
        public IFormFile AuthorImageFile { get; set; }
    }
}
