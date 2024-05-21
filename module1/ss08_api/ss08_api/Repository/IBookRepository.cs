using ss08_api.Data;
using ss08_api.Models;

namespace ss08_api.Repository
{
    public interface IBookRepository
    {
        public Task<List<BookModel>> GetAllBooksAsync();
        public Task<BookModel> GetBookByIdAsync(int id);
        public Task<BookModel> AddBookAsync(BookModel book);
        public Task UpdateBookAsync(int id,BookModel book);
        public Task DeleteBookAsync(int id);
    }
}
