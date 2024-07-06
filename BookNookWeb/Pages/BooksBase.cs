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

        protected IOrderedEnumerable<IGrouping<int, BookAuthorDto>> GetGroupedBooksByGenre()
        {
            return from book in BookAuthors
                   group book by book.CategoryId into booksbyGenre
                   orderby booksbyGenre.Key
                   select booksbyGenre;
        }

        protected string GetGenreByName(IGrouping<int, BookAuthorDto> groupedBooksDtos)
        {
            return groupedBooksDtos.FirstOrDefault(pg => pg.CategoryId == groupedBooksDtos.Key).CategoryGenre;
        }
    }
}
