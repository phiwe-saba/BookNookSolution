using BookNookApi.Entities;
using BookNookApi.Extensions;
using BookNookApi.Repositories.Contracts;
using BookNookModels.Dtos;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookNookApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookController : ControllerBase
    {
        private readonly IBookRepository bookRepository;

        public BookController(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<BookAuthorDto>>> GetBooks()
        {
            try
            {
                var books = await this.bookRepository.GetBooks();
                var bookCategories = await this.bookRepository.GetCategories();
                var bookAuthors = await this.bookRepository.GetAllBookAuthors();
                var authors = await this.bookRepository.GetAllAuthors();

                if (books == null || bookCategories == null || bookAuthors == null || authors == null)
                {
                    return NotFound();
                }
                else
                {
                    var booksDtos = books.ConvertToDto(bookCategories, authors, bookAuthors);
                    return Ok(booksDtos);
                }
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }

        [HttpGet("{id:int}")]
        public async Task<ActionResult<BookAuthorDto>> GetBookAuthor(int id)
        {
            try
            {
                var bookAuthor = await this.bookRepository.GetBookAuthor(id);
                var author = await this.bookRepository.GetAuthor(id);
                var book = await this.bookRepository.GetBook(id);

                if (bookAuthor == null || bookAuthor.Book == null || bookAuthor.Author == null)
                {
                    return BadRequest("Book or author not found");
                }

                var bookCategory = await this.bookRepository.GetCategory(bookAuthor.Book.CategoryId);

                if (bookCategory == null)
                {
                    return BadRequest("Category not found"); 
                }

                var bookDto = bookAuthor.ConvertToDto(bookCategory, bookAuthor.Author);
                return Ok(bookDto);
            }
            catch (Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error retrieving data from the database");
            }
        }
    }
}
