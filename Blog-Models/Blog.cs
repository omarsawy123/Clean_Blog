using System;

namespace Blog_Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Author Author { get; set; }
        public DateTime DatePublished { get; set; }
        public string Content { get; set; }
       

    }
}
