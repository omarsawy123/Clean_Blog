using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Blog_API.Models;
using Blog_Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Blog_API.Controllers
{
    [Route("/Blogs")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            this.blogRepository = blogRepository;
        }
        
        [HttpGet]
        public async Task<ActionResult> GetBlogs()
        {
            try
            {
                var result = await blogRepository.GetBlogs();
                return Ok(result);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet("{Id:int}")]
        public async Task<ActionResult<Blog>> GetBlog(string Id)
        {
            try
            {
                var result = await blogRepository.GetBlog(Id);
                
                if (result == null)
                {
                    return NotFound();
                }

                return result;
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpPost]
        
        public async Task<ActionResult<Blog>> AddBlog(Blog newBlog)
        {
            try
            {
                if (newBlog == null)
                {
                    return BadRequest(); 
                }

                var CheckIfExists = await blogRepository.GetBlog(newBlog.Id);

                if (CheckIfExists != null)
                {
                    ModelState.AddModelError("Id","Blog Already Exists");
                    return BadRequest(ModelState);
                }

                var result = await blogRepository.AddBlog(newBlog);

                return CreatedAtAction(nameof(GetBlog), new { Id = newBlog.Id },newBlog);
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");

            }
        } 

        [HttpPut]

        public async Task<ActionResult<Blog>> EditBlog(Blog editedBlog)
        {
            try
            {
                var updatedBlog = await blogRepository.GetBlog(editedBlog.Id);
                if (updatedBlog == null)
                {
                    return NotFound("Blog cannot be found");
                }

                return await blogRepository.EditBlog(editedBlog);
                
            }
            catch (Exception)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");

            }
        }

        [HttpDelete("{Id:int}")]
        
        public async Task<ActionResult<Blog>> deleteBlog(string Id)
        {
            var result = await blogRepository.GetBlog(Id);

            if (result == null)
            {
                return NotFound("Blog not found");
            }

            return await blogRepository.DeleteBlog(Id);

        }


    }
}











