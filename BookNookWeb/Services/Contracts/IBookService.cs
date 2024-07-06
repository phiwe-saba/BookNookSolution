using BookNookModels.Dtos;

namespace BookNookWeb.Services.Contracts
{
    public interface IBookService
    {
        Task<IEnumerable<BookAuthorDto>> GetBooks();
        Task<BookAuthorDto> GetBookAuthor(int id);
    }
}
