using Microsoft.EntityFrameworkCore;

namespace ss02.Models
{
    public class DemoSS02Context : DbContext
    {
        public DemoSS02Context(DbContextOptions<DemoSS02Context> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



        }
        public DbSet<Post> Posts { get; set; }
        public DbSet<Category> categories { get; set; }
        public DbSet<PostCategory> PostCategories { get; set; }

    }
}
