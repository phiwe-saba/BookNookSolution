using BookNookApp.Services.Contracts;
using BookNookModels.Dtos;
using System.Net.Http.Json;

namespace BookNookApp.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient httpClient;

        public BookService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<BookAuthorDto>> GetBooks()
        {
            try
            {
                var books = await this.httpClient.GetFromJsonAsync<IEnumerable<BookAuthorDto>>("api/Book");
                return books;
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
