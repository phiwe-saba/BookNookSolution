using BookNookApi.Entities;

namespace BookNookApi.Repositories.Contracts
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<IEnumerable<BookCategory>> GetCategories();
        Task<Book> GetBook(int id);
        Task<BookCategory> GetCategory(int id);
    }
}
