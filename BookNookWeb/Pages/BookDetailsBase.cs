using BookNookModels.Dtos;
using BookNookWeb.Services.Contracts;
using Microsoft.AspNetCore.Components;

namespace BookNookWeb.Pages
{
    public class BookDetailsBase : ComponentBase
    {
        [Parameter]
        public int Id { get; set; }
        [Inject]
        public IBookService BookService { get; set; }
        public BookAuthorDto BookAuthor { get; set; }
        public string ErrorMessage { get; set; }
        protected override async Task OnInitializedAsync()
        {
            try
            {
                BookAuthor = await BookService.GetBookAuthor(Id);
            }
            catch (Exception ex)
            {
                ErrorMessage = ex.Message;
            }
        }
    }
}
