using Blog_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_API.Models
{
    public interface IBlogRepository
    {
        Task<IEnumerable<Blog>> GetBlogs();
        Task <Blog> GetBlog(int blogId);
       


    }
}
