using System;
using System.ComponentModel.DataAnnotations;

namespace WebApi
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 250, MinimumLength = 10)]
        public string Title { get; set; } 
        [Required]
        [Range(1,3,ErrorMessage ="GenreId must be between 1 and 3 only!!")]      
        public int GenreId { get; set; }
        [Required]
        [Range(1,2500,ErrorMessage ="PageCount must be between 1 and 100 only!!")] 
        public int PageCount { get; set; }
        public DateTime PublishDate { get; set; }
    }
}