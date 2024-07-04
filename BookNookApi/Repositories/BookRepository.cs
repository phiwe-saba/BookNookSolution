using BookNookApi.Data;
using BookNookApi.Entities;
using BookNookApi.Repositories.Contracts;
using Microsoft.EntityFrameworkCore;

namespace BookNookApi.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly BookNookDbContext bookNookDbContext;
        public BookRepository(BookNookDbContext _bookNookDbContext)
        {
            this.bookNookDbContext = _bookNookDbContext;
        }

        public BookNookDbContext BookNookDbContext { get; }

        public Task<Book> GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Book>> GetBooks()
        {
            var books = await this.bookNookDbContext.Books.ToListAsync();
            return books;
        }

        public async Task<IEnumerable<BookCategory>> GetCategories()
        {
            var categories = await this.bookNookDbContext.BookCategories.ToListAsync();
            return categories;
        }

        public Task<BookCategory> GetCategory(int id)
        {
            throw new NotImplementedException();
        }
    }
}
