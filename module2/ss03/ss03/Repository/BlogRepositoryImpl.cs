using Microsoft.EntityFrameworkCore;
using ss03.Models;

namespace ss03.Repository
{
    public class BlogRepositoryImpl : IBlogRepository
    {
        private readonly DemoContext _context;

        public BlogRepositoryImpl(DemoContext context)
        {
            _context = context;
        }

        public async Task CreateBlog(Blog blog)
        {
            await _context.Blogs.AddAsync(blog);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteBlog(Blog blog)
        {
            _context.Blogs.Remove(blog);
            await _context.SaveChangesAsync();
        }

        public async Task<Blog?> FindById(int id)
        {
            
            return await _context.Blogs.Where(b=>b.Id==id).FirstOrDefaultAsync();
           
        }

        public async Task<List<Blog>> GetAll()
        {
            return await _context.Blogs.ToListAsync();
        }

        public async Task UpdateBlog(Blog blog)
        {
            _context.Blogs.Update(blog);
            await _context.SaveChangesAsync();
        }
    }
}
