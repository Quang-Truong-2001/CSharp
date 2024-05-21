using Microsoft.EntityFrameworkCore;

namespace ss04.Models
{
    public class DbContextBookStore : DbContext
    {
        public DbContextBookStore(DbContextOptions<DbContextBookStore> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            base.OnConfiguring(builder);
            // Tự động nạp các Reference ko nen dung
            //builder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {


            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Book>(entity =>
            {
                // Table mapping
                //[Table("books")]
                entity.ToTable("books");
                //Pk
                //[Key]
                entity.HasKey(p => p.Id);
                //Index
                entity.HasIndex(p => p.Name)
                    .HasDatabaseName("index-book-name");
                // Relative: mqh
                // 1-n
                entity.HasOne(b => b.Author)
                        .WithMany() //Author khong co propertiess book 
                        .HasForeignKey(b=>b.IdAuthor)
                        //.OnDelete(DeleteBehavior.Cascade); // xóa phần 1 sẽ đi đôi với xóa phần nhiều 
                        .OnDelete(DeleteBehavior.NoAction); // xóa phần 1 sẽ không xóa phần nhiều 
                        //.OnDelete(DeleteBehavior.SetNull); // update bằng giá trị null  khi thuoc tinh co the nhân gia tri null 
                // 1-1
                //entity.HasOne(b=>b.BookDetail)
                //      .WithOne(d => b.Book)
                //      .HashForeignKey<BookDetail>(b=>b.id)
                //      .OnDelete(DeleteBehavior.NoAction);
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.HasIndex(e => e.UserName).IsUnique();
                entity.Property(e => e.FullName).IsRequired().HasMaxLength(150);
                entity.Property(e => e.Email).IsRequired().HasMaxLength(150);
            });




        }
        public DbSet<Book> Books { get; set;}
        public DbSet<Category> Categories { get; set;}
        public DbSet<Author> Authors { get; set;}
        public DbSet<User> Users { get; set;}
        public DbSet<RefreshToken> RefreshTokens { get; set; }


    }
}
