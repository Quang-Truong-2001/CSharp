using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ss03.Repository;
using System.Reflection.Metadata;
using ss03.Models;

namespace ss03.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogController : ControllerBase
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _blogRepository.GetAll());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> FindBlog([FromRoute] int id)
        {
            Blog blog= await _blogRepository.FindById(id);
            if(blog == null)
            {
                return NotFound();
            }
            return Ok(blog);
        }
        [HttpDelete("delete/{id}")]
        public async Task<IActionResult> DeleteBlog([FromRoute] int id)
        {
            Blog blog = await _blogRepository.FindById(id);
            if (blog == null)
            {
                return NotFound();
            }
            await _blogRepository.DeleteBlog(blog);
            return Ok(blog);
        }
        [HttpPatch("/update")]
        public async Task<IActionResult> UpdateBLog([FromBody] Blog newBlog)
        {
            Blog blog=await _blogRepository.FindById(newBlog.Id);
            if (blog == null)
            {
                return NotFound();
            }
            await _blogRepository.UpdateBlog(newBlog);
            return Ok(newBlog);
        }


    }
}
