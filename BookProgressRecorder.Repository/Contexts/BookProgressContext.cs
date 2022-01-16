using BookProgressRecorder.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookProgressRecorder.Repository.Context
{
    public class BookProgressContext : DbContext
    {
        public BookProgressContext(DbContextOptions<BookProgressContext> options)
            : base(options)
        {
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookStatus> BookStatuses { get; set; }
        public DbSet<User> Users { get; set; }
    }
}
