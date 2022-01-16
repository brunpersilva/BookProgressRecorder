using BookProgressRecorder.Repository.Books;
using BookProgressRecorder.Repository.Context;

namespace BookProgressRecorder.Repository.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly BookProgressContext _context;

        public UnitOfWork(BookProgressContext context)
        {
            _context = context;
            Books = new BookRepository(_context);
        }

        public IBookRepository Books { get; private set; }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
