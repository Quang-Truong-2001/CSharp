using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ss04.Models;
using ss04.Repository;
using ss04.Repository.Impl;

namespace ss04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryRepository _categoryRepository;

        public CategoryController(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }

        [HttpDelete("remove/{id}")]
        public IActionResult RemoveCategory([FromRoute] int id)
        {
            var category = _categoryRepository.GetById(id);
            _categoryRepository.DeleteBook(category);
            return Ok(category);
        }

    }
}
