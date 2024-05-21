using Microsoft.EntityFrameworkCore;
using ss04.Models;
using System.Data.SqlClient;

namespace ss04.Repository.Impl
{
    public class BookRepositoryImpl : IBookRepository
    {
        private readonly DbContextBookStore _context;

        public BookRepositoryImpl(DbContextBookStore context)
        {
            _context = context;
        }

        public void CreateBook(Book book)
        {
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void DeleteBook(Book book)
        {
            #region update1

            var affectedRows = _context.Database.ExecuteSqlRaw("UPDATE books SET IsDeleted = 1 WHERE id={0}", book.Id);

            #endregion


            #region update2
            //book.IsDeleted=true;
            //_context.Books.Update(book);
            //_context.SaveChanges();
            #endregion
            //_context.Books.Remove(book);
        }

        public List<Book> GetAll()
        {
            //return _context.Books.Include(b => b.Author).Include(b => b.Category).ToList();
            string sql = "select * from books";
            //var books = _context.Books.FromSqlRaw(sql);
            var books = _context.Books.FromSqlRaw(sql).Include(b => b.Author).Include(b => b.Category);

            return books.ToList();
        }

        public Book GetById(int id)
        {
            var book = (from b in _context.Books where b.Id == id select b).Include(b => b.Category).Include(b => b.Author).FirstOrDefault();
                //var c=_context.Entry(book);
            //// Lấy dữ liệu từ bảng phụ
            //c.Reference(b => b.Author).Load();
            //c.Reference(b => b.Category).Load();
            return book;
            
        }

        public void UpdateBook(Book book)
        {
            _context.Books.Update(book);
            _context.SaveChanges();
        }
    }
}
