using System;
using System.ComponentModel.DataAnnotations;

namespace Blog_Models
{
    public class Blog
    {
        public string Id { get; set; }

        [Required]
        [MinLength(5)]
        public string Name { get; set; }

        
        public string AuthorId { get; set; }
        
        
        public string DatePublished { get; set; }
        
        [Required]
        public string Content { get; set; }
        
        [Required]

        public string Category { get; set; }
    }
}
