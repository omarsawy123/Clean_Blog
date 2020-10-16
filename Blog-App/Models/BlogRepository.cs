using Blog_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
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

        public async Task<Blog> AddBlog(Blog newBlog)
        {

            var result = await context.Blogs.AddAsync(newBlog);
            await context.SaveChangesAsync();
            return result.Entity;

        }

        public async Task<Blog> DeleteBlog(string blogId)
        {
            var result = await context.Blogs.FirstOrDefaultAsync(e => e.Id == blogId);
            context.Remove(result);
            await context.SaveChangesAsync();
            return result;
        }

        public async Task<Blog> EditBlog(Blog editedBlog)
        {

            var result = await context.Blogs.FirstOrDefaultAsync(e => e.Id == editedBlog.Id);
            
            if (result != null)
            {
                context.Entry(result).CurrentValues.SetValues(editedBlog);

                await context.SaveChangesAsync();

                return result;
            }

            return null;

        }

        public async Task<Blog> GetBlog(string blogId)
        {
            return await context.Blogs.FirstOrDefaultAsync(e => e.Id == blogId);
        }

        public async Task<IEnumerable<Blog>> GetBlogs()
        {
            return await context.Blogs.ToListAsync();
        }
    }
}
