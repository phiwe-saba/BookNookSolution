using BookNookModels.Dtos;
using BookNookWeb.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace BookNookWeb.Pages
{
    public class BooksBase : ComponentBase
    {
        [Inject]
        public IBookService BookService { get; set; }
        public IEnumerable<BookAuthorDto> BookAuthors { get; set; }
        protected override async Task OnInitializedAsync()
        {
            BookAuthors = await BookService.GetBooks();
        }
    }
}
