using ss04.Models;

namespace ss04.Repository.Impl
{
    public class AuthorRepositoryImpl : IAuthorRepository   
    {
        private readonly DbContextBookStore _context;

        public AuthorRepositoryImpl(DbContextBookStore context)
        {
            _context = context;
        }

        public void CreateBook(Author t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Author t)
        {
            throw new NotImplementedException();
        }

        public List<Author> GetAll()
        {
            throw new NotImplementedException();
        }

        public Author GetById(int id)
        {
            return (from a in _context.Authors where a.Id==id select a).FirstOrDefault();
        }

        public void UpdateBook(Author t)
        {
            throw new NotImplementedException();
        }
    }
}
