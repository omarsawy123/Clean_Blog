using Blog_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_API.Models
{
    public class BlogRepository : IBlogRepository
    {

        private readonly AppDBContext context;

        public BlogRepository(AppDBContext context)
        {
            this.context = context;
        }

        public async Task<Blog> GetBlog(int blogId)
        {
            return await context.Blogs.FirstOrDefaultAsync(e => e.Id == blogId);
        }

        public async Task<IEnumerable<Blog>> GetBlogs()
        {
            return await context.Blogs.ToListAsync();
        }
    }
}
