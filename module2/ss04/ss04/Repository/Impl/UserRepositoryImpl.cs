using ss04.Models;

namespace ss04.Repository.Impl
{
    public class UserRepositoryImpl : IUserRepository
    {
        private readonly DbContextBookStore _context;

        public UserRepositoryImpl(DbContextBookStore context)
        {
            _context = context;
        }

        public void CreateBook(User t)
        {
            throw new NotImplementedException();
        }

        public void DeleteBook(User t)
        {
            throw new NotImplementedException();
        }

        public User FindUser(string username)
        {
            return _context.Users.Where(u => u.UserName.Equals(username)).FirstOrDefault();
        }

        public List<User> GetAll()
        {
            throw new NotImplementedException();
        }

        public User GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(User t)
        {
            throw new NotImplementedException();
        }
    }
}
