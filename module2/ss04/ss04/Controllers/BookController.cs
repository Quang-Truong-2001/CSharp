using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ss04.Models;
using ss04.Repository;
using ss04.Dto;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;

namespace ss04.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;
        private readonly ICategoryRepository _categoryRepository;
        private readonly IAuthorRepository _authorRepository;
        private readonly IMapper _mapper;

        public BookController(IBookRepository bookRepository, IMapper mapper,ICategoryRepository categoryRepository, IAuthorRepository authorRepository)
        {
            _bookRepository = bookRepository;
            _categoryRepository = categoryRepository;
            _authorRepository = authorRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
           
            return Ok(_bookRepository.GetAll());
        }

        [HttpGet("{id}")]
        //[Authorize]
        public IActionResult GetBook([FromRoute] int id)
        {

            return Ok(_bookRepository.GetById(id));
        }
        [HttpPost]
        //[Authorize(Policy = IdentityData.AdminUserPolicyName)]
        public IActionResult CreateBook([FromBody] BookDto bookDto)
        {
            try
            {
                if(!ModelState.IsValid)
                {
                    return UnprocessableEntity(ModelState);//422 
                }
                Book book= _mapper.Map<Book>(bookDto);
                book.Category=_categoryRepository.GetById(bookDto.IdCategory);
                book.Author = _authorRepository.GetById(bookDto.IdAuthor);
                _bookRepository.CreateBook(book);
                return Ok();

            }catch(Exception ex)
            {
                return BadRequest();
            }

        }
        [HttpDelete("delete/{id}")]
        public IActionResult DeleteBook(int id)
        {
            var book=_bookRepository.GetById(id);
            if (book == null)
            {
                return NotFound();
            }
            _bookRepository.DeleteBook(book);
            return Ok();
        }
    }
}
