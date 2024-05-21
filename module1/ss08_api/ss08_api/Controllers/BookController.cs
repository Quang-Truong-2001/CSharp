using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ss08_api.Models;
using ss08_api.Repository;

namespace ss08_api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository _bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            _bookRepository = bookRepository;
        }


        [HttpGet]
        public async Task<IActionResult> GetAllBooks()
        {
            try
            {
                return Ok(await _bookRepository.GetAllBooksAsync());
            }
            catch
            {
                return BadRequest();
            }
        }

        [HttpGet("/{id}")]
        public async Task<IActionResult> GetBookById(int id)
        {
            var book=await _bookRepository.GetBookByIdAsync(id);
            if (book == null)
            {
                return NotFound();
            }
            return Ok(book);
        }

        [HttpPost]
        public async Task<IActionResult> AddNewBook([FromBody]BookModel bookModel)
        {
            try
            {
                var newBook = await _bookRepository.AddBookAsync(bookModel);
                return Ok(newBook);
            }
            catch
            {
                return BadRequest();
            }
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteBook([FromRoute] int id)
        {
            await _bookRepository.DeleteBookAsync(id);
            return Ok();
        }

    }
}
