using ss04.Models;

namespace ss04.Repository
{
    public interface IRepository<T>
    {
        List<T> GetAll();
        T GetById(int id);
        void DeleteBook(T t);
        void UpdateBook(T t);
        void CreateBook(T t);
    }
}
