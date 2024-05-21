using ss03.Models;

namespace ss03.Repository
{
    public interface IBlogRepository
    {
        public Task<List<Blog>> GetAll();
        public Task<Blog> FindById(int id);
        public Task CreateBlog(Blog blog);

        public Task UpdateBlog(Blog blog);
        public Task DeleteBlog(Blog blog);
    }
}
