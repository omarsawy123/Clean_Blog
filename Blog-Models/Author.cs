using System;
using System.Collections.Generic;
using System.Text;

namespace Blog_Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Specialty Specialty { get; set; }
        public Blog Blogs { get; set; }

    }
}
