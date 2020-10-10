using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Blog_Models
{
    public class Author
    {
        
        public int Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }

        [Required]
        public Specialty Specialty { get; set; }

        [Required]
        public IEnumerable<Blog> Blogs { get; set; }

    }
}
