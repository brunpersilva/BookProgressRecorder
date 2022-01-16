using BookProgressRecorder.Repository.Books;

namespace BookProgressRecorder.Repository.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IBookRepository Books { get; }
        Task<int> CompleteAsync();
    }
}
