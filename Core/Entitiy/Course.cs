using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.AspNetCore.Http;

namespace Core.Entitiy
{
    public class Course
    {
        public int  Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public string CoverImage{ get; set; }
        [NotMapped]

        public IFormFile CoverImageFile { get; set; }
        public string AuthorName { get; set; }
        public string AuthorImage { get; set; }
        [NotMapped]
        public IFormFile AuthorImageFile { get; set; }





    }
}
