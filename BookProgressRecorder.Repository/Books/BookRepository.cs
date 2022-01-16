using BookProgressRecorder.Domain.Entities;
using BookProgressRecorder.Repository.Base;
using BookProgressRecorder.Repository.Context;

namespace BookProgressRecorder.Repository.Books
{
    public class BookRepository : Repository<Book>, IBookRepository
    {
        public BookRepository(BookProgressContext context) :
            base(context)
        {
        }

        public async Task<IEnumerable<Book>> GetAllCompletedBooksAsync()
        {
            throw new NotImplementedException();
        }

        public BookProgressContext BookContext
        {
            get { return Context as BookProgressContext; }
        }
    }
}
