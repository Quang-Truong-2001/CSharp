using ss04.Models;

namespace ss04.Repository
{
    public interface IBookRepository
    {
        List<Book> GetAll();
        Book GetById(int id);
        void DeleteBook(Book book);
        void UpdateBook(Book book);
        void CreateBook(Book book);
    }
}
