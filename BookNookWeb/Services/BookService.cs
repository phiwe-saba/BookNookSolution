using BookNookModels.Dtos;
using BookNookWeb.Services.Contracts;
using System.Net.Http.Json;

namespace BookNookWeb.Services
{
    public class BookService : IBookService
    {
        private readonly HttpClient httpClient;

        public BookService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<BookAuthorDto> GetBookAuthor(int id)
        {
            try
            {
                var response = await httpClient.GetAsync($"api/Book/{id}");

                if (response.IsSuccessStatusCode)
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.NoContent)
                    {
                        return default(BookAuthorDto);
                    }

                    return await response.Content.ReadFromJsonAsync<BookAuthorDto>();
                }
                else
                {
                    var message = await response.Content.ReadAsStringAsync();
                    throw new Exception(message);
                }
                
            }
            catch (Exception)
            {

                throw;
            }
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
