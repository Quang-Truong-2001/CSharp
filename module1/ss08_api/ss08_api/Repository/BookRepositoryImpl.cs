using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ss08_api.Data;
using ss08_api.Models;

namespace ss08_api.Repository
{
    public class BookRepositoryImpl : IBookRepository
    {
        private readonly BookStoreContext _context;
        private readonly IMapper _mapper;
        public BookRepositoryImpl(BookStoreContext context, IMapper mapper) 
        {
            _context = context;
            _mapper=mapper;
        }

        public async Task<BookModel> AddBookAsync(BookModel book)
        {
            var newBook = _mapper.Map<Book>(book);
            _context.Books!.Add(newBook);
            await _context.SaveChangesAsync();
            return book;
        }

        public async Task DeleteBookAsync(int id)
        {
            var deleteBook = _context.Books!.SingleOrDefault(b => b.Id == id);
            if (deleteBook != null)
            {
                _context.Books!.Remove(deleteBook);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<BookModel>> GetAllBooksAsync()
        {
            var books = await _context.Books!.ToListAsync();
            return _mapper.Map<List<BookModel>>(books);
        }

        public async Task<BookModel> GetBookByIdAsync(int id)
        {
            var book = await _context.Books!.FindAsync(id);
            return _mapper.Map<BookModel>(book);
           
        }

        public async Task UpdateBookAsync(int id, BookModel book)
        {
            if (id == book.Id)
            {
                var updateBook = _mapper.Map<Book>(book);
                _context.Books!.Update(updateBook);
                await _context.SaveChangesAsync();
            }
        }
    }
}
