using BookNookApi.Extensions;
using BookNookApi.Repositories.Contracts;
using BookNookModels.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookNookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShoppingCartController : ControllerBase
    {
        private IShoppingCartRepository shoppingCartRepository;
        private IBookRepository bookRepository;

        public ShoppingCartController(IShoppingCartRepository shoppingCartRepository, IBookRepository bookRepository)
        {
            this.shoppingCartRepository = shoppingCartRepository;
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        [Route("{userId}/GetItems")]
        public async Task<ActionResult<IEnumerable<CartItemDto>>> GetItems(int userId)
        {
            try
            {
                var cartItems = await this.shoppingCartRepository.GetItems(userId);

                if (cartItems == null)
                {
                    return NoContent();
                }

                var books = await this.bookRepository.GetBooks();

                if (books == null)
                {
                    throw new Exception("No items exist in the system");
                }

                var cartItemsDto = cartItems.ConvertToDto(books);

                return Ok(cartItemsDto);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        
    }
}
