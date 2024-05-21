using Microsoft.EntityFrameworkCore;
using System;

namespace ss01.Models
{
    public class DemoContext : DbContext
    {
        public DemoContext(DbContextOptions<DemoContext> options) : base(options)
        {
            //..
            // this.Roles
            // IdentityRole<string>
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
        public DbSet<Category> Categorys { get; set; }
        public DbSet<PostCategory> PostCategorys { get; set; }
      
    }
}
