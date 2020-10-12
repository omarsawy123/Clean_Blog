using System;
using System.ComponentModel.DataAnnotations;

namespace Blog_Models
{
    public class Blog
    {
        public int Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Title { get; set; }

        [Required]
        public int AuthorId { get; set; }
        
        [Required]
        public DateTime DatePublished { get; set; }
        
        [Required]
        public string Content { get; set; }
       

    }
}
