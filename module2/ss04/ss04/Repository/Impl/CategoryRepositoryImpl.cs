using ss04.Models;

namespace ss04.Repository.Impl
{
    public class CategoryRepositoryImpl : ICategoryRepository   
    {
        private readonly DbContextBookStore _context;

        public CategoryRepositoryImpl(DbContextBookStore context)
        {
            _context = context;
        }

        public void CreateBook(Category t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(Category t)
        {
            _context.Categories.Remove(t);
        }

        public List<Category> GetAll()
        {
            throw new NotImplementedException();
        }

        public Category GetById(int id)
        {
            return (from  c in _context.Categories where  c.Id == id select c).FirstOrDefault();
        }

        public void UpdateBook(Category t)  
        {
            throw new NotImplementedException();
        }
    }
}
