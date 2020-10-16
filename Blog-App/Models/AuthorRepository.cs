using Blog_Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_API.Models
{
    public class AuthorRepository : IAuthorRepository
    {
        private readonly AppDBContext context;

        public AuthorRepository(AppDBContext context)
        {
            this.context = context;
        }
        public async Task<Author> GetAuthor(string authorId)
        {
            return await context.Authors.FirstOrDefaultAsync(e => e.Id == authorId);
        }

        public async Task<IEnumerable<Author>> GetAuthors()
        {
            return await context.Authors.ToListAsync();
        }
    }
}
