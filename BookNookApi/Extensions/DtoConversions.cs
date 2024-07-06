using BookNookApi.Entities;
using BookNookModels.Dtos;

namespace BookNookApi.Extensions
{
    public static class DtoConversions
    {
        public static IEnumerable<BookAuthorDto> ConvertToDto(this IEnumerable<Book> books, IEnumerable<BookCategory> bookCategories, IEnumerable<Author> authors, IEnumerable<BookAuthor> bookAuthors)
        {
            return (from book in books
                    join bookAuthor in bookAuthors on book.Id equals bookAuthor.BookId
                    join bookCategory in bookCategories on book.CategoryId equals bookCategory.Id
                    join author in authors on bookAuthor.AuthorId equals author.Id
                    select new BookAuthorDto
                    {
                        Id = book.Id,
                        Title = book.Title,
                        Description = book.Description,
                        ImageUrl = book.ImageUrl,
                        ISBN = book.ISBN,
                        Price = book.Price,
                        Qty = book.Qty,
                        CategoryId = book.CategoryId,
                        CategoryGenre = bookCategory.Genre,
                        AuthorId = bookAuthor.AuthorId,
                        AuthorName = author.Name
                    }).ToList();
        }

        public static BookAuthorDto ConvertToDto(this BookAuthor bookAuthor, BookCategory bookCategory, Author author)
        {
            return new BookAuthorDto
            {
                Id = bookAuthor.Book.Id,
                Title = bookAuthor.Book.Title,
                Description = bookAuthor.Book.Description,
                ImageUrl = bookAuthor.Book.ImageUrl,
                ISBN = bookAuthor.Book.ISBN,
                Price = bookAuthor.Book.Price,
                Qty = bookAuthor.Book.Qty,
                CategoryId = bookAuthor.Book.CategoryId,
                CategoryGenre = bookCategory.Genre,
                AuthorId = bookAuthor.Author.Id,
                AuthorName = author.Name
            }; 
        }
    }
}
