using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;

namespace Blog_Models
{
    public class Author
    {
        
        public string Id { get; set; }

        [Required]
        [MinLength(2)]
        public string Name { get; set; }


        
    }
}
