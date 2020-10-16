using Blog_Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blog_API.Models
{
    public interface IAuthorRepository
    {
        Task<Author> GetAuthor(string authorId);

        Task<IEnumerable<Author>> GetAuthors();
    }
}
