using BookNookApi.Entities;
using Microsoft.EntityFrameworkCore;

namespace BookNookApi.Data
{
    public class BookNookDbContext : DbContext
    {
        public BookNookDbContext(DbContextOptions<BookNookDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Books
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "To Kill A Mockingbird",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/2657._SX300_.jpg",
                Price = 150,
                Qty = 100,
                ISBN = "978-3-16-148410-0",
                CategoryId = 1
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 2,
                Title = "Water for Elephants",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/43641._SX300_.jpg",
                Price = 125,
                Qty = 100,
                ISBN = "978-3-16-148410-0",
                CategoryId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 3,
                Title = "The Help",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/4667024.jpg",
                Price = 100,
                Qty = 100,
                ISBN = "978-3-16-148410-0",
                CategoryId = 3
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 4,
                Title = "Lovely Bones",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/12232938._SX300_.jpg",
                Price = 150,
                Qty = 100,
                ISBN = "978-3-16-148410-0",
                CategoryId = 4
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 5,
                Title = "Code Girls",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/34184307._SX300_.jpg",
                Price = 150,
                Qty = 100,
                ISBN = "978-3-16-148410-0",
                CategoryId = 5
            });

            // Book Authors
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 1,
                AuthorId = 1,
                BookId = 1
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 2,
                AuthorId = 2,
                BookId = 2
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 3,
                AuthorId = 3,
                BookId = 3
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 4,
                AuthorId = 4,
                BookId = 4
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 5,
                AuthorId = 5,
                BookId = 5
            });

            // Author
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 1,
                Name = "Harper Lee",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 2,
                Name = "Sara Gruen",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 3,
                Name = "Kathryn Stockett",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 4,
                Name = "Lovely Bones",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 5,
                Name = "Liza Mundy",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });

            // Book Categories
            modelBuilder.Entity<BookCategory>().HasData(new BookCategory
            {
                Id = 1,
                Genre = "Narrative"
            });
            modelBuilder.Entity<BookCategory>().HasData(new BookCategory
            {
                Id = 2,
                Genre = "Fiction"
            });
            modelBuilder.Entity<BookCategory>().HasData(new BookCategory
            {
                Id = 3,
                Genre = "Non-Fiction"
            });
            modelBuilder.Entity<BookCategory>().HasData(new BookCategory
            {
                Id = 4,
                Genre = "Romance"
            });
            modelBuilder.Entity<BookCategory>().HasData(new BookCategory
            {
                Id = 5,
                Genre = "Drama"
            });

            // Adding users
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 1,
                UserName = "Phiwe"
            });
            modelBuilder.Entity<User>().HasData(new User
            {
                Id = 2,
                UserName = "Saba"
            });

            // Shopping Cart for users
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 1,
                UserId = 1
            });
            modelBuilder.Entity<Cart>().HasData(new Cart
            {
                Id = 2,
                UserId = 2
            });
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
        public DbSet<BookAuthor> BookAuthors { get; set; }
        public DbSet<BookCategory> BookCategories { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
    }
}
