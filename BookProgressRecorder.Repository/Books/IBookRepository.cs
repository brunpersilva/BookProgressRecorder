using BookProgressRecorder.Domain.Entities;
using BookProgressRecorder.Repository.Base;

namespace BookProgressRecorder.Repository.Books
{
    public interface IBookRepository : IRepository<Book>
    {
        Task<IEnumerable<Book>> GetAllCompletedBooksAsync();
    }
}
