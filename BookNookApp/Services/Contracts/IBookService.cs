using BookNookModels.Dtos;

namespace BookNookApp.Services.Contracts
{
    public interface IBookService
    {
        Task<IEnumerable<BookAuthorDto>> GetBooks();
    }
}
