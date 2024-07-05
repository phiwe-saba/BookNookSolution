using BookNookApp.Services.Contracts;
using BookNookModels.Dtos;
using Microsoft.AspNetCore.Components;

namespace BookNookApp.Pages
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
