using BookNookModels.Dtos;
using Microsoft.AspNetCore.Components;

namespace BookNookWeb.Pages
{
    public class DisplayBooksBase : ComponentBase
    {
        [Parameter]
        public IEnumerable<BookAuthorDto> BookAuthors { get; set; }
    }
}
