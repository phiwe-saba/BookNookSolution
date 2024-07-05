using BookNookApi.Entities;

namespace BookNookApi.Repositories.Contracts
{
    public interface IBookRepository
    {
        Task<IEnumerable<Book>> GetBooks();
        Task<IEnumerable<BookCategory>> GetCategories();
        Task<IEnumerable<BookAuthor>> GetAllBookAuthors();
        Task<IEnumerable<Author>> GetAllAuthors();
        Task<Book> GetBook(int id);
        Task<BookCategory> GetCategory(int id);
        Task<BookAuthor> GetBookAuthor(int id);
        Task<Author> GetAuthor(int id);
        
    }
}
