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

        public async Task<IEnumerable<Author>> GetAllAuthors()
        {
            var authors = await this.bookNookDbContext.Authors.ToListAsync();
            return authors;
        }

        public async Task<IEnumerable<BookAuthor>> GetAllBookAuthors()
        {
            var bookAuthors = await this.bookNookDbContext.BookAuthors.ToListAsync();
            return bookAuthors;
        }

        public Task<BookAuthor> GetAuthor(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Book> GetBook(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<BookAuthor> GetBookAuthor(int id)
        {
            var bookAuthor = await bookNookDbContext.BookAuthors.SingleOrDefaultAsync(ba => ba.Id == id);
            return bookAuthor;
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

        public async Task<BookCategory> GetCategory(int id)
        {
            var category = await bookNookDbContext.BookCategories.SingleOrDefaultAsync(c => c.Id == id);
            return category;
        }

        Task<Author> IBookRepository.GetAuthor(int id)
        {
            throw new NotImplementedException();
        }
    }
}
