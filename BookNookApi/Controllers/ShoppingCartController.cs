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

        [HttpGet("{id:int}")]
        public async Task<ActionResult<CartItemDto>> GetItem(int id)
        {
            try
            {
                var cartItem = await this.shoppingCartRepository.GetItem(id);

                if (cartItem == null)
                {
                    return NotFound();
                }

                var book = await bookRepository.GetBook(cartItem.BookId);

                if (book == null)
                {
                    return NotFound();
                }

                var cartItemDto = cartItem.ConvertToDto(book);

                return Ok(cartItemDto);
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpPost]
        public async Task<ActionResult<CartItemDto>> PostItem([FromBody] CartItemToAddDto cartItemToAddDto)
        {
            try
            {
                var newCartItem = await this.shoppingCartRepository.AddItem(cartItemToAddDto);

                if (newCartItem == null)
                {
                    return NoContent();
                }

                var book = await bookRepository.GetBook(newCartItem.BookId);

                if (book == null)
                {
                    throw new Exception($"Something went wrong when attempting to retrieve book (bookId:({cartItemToAddDto.BookId}))");
                }

                var newCartItemDto = newCartItem.ConvertToDto(book);

                return CreatedAtAction(nameof(GetItem), new { id = newCartItemDto.Id }, newCartItemDto);
            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
