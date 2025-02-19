﻿using Microsoft.EntityFrameworkCore;

namespace ss08_api.Data
{
    public class BookStoreContext: IdentityDbContext<ApplicationUser>
    {
        public BookStoreContext(DbContextOptions<BookStoreContext> opt) : base(opt)
        {

        }
        #region DbSet
        public DbSet<Book>? Books { get; set; }
        #endregion

    }


}
