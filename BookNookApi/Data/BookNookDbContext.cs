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
            // Narrative
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 1,
                Title = "To Kill A Mockingbird",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/2657._SX300_.jpg",
                Price = 150,
                Qty = 100,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-20.png",
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
                Rating = "images/ratings/rating-30.png",
                CategoryId = 1
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
                Rating = "images/ratings/rating-10.png",
                CategoryId = 1
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
                Rating = "images/ratings/rating-15.png",
                CategoryId = 1
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
                Rating = "images/ratings/rating-35.png",
                CategoryId = 1
            });

            //Fiction
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 6,
                Title = "The Guernsey",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/39832183.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-05.png",
                CategoryId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 7,
                Title = "Hollywood Horrors",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/56359706._SX300_.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-30.png",
                CategoryId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 8,
                Title = "Vanderbilt",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/56382342.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-15.png",
                CategoryId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 9,
                Title = "Capote's Women",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/57005206._SX300_.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-50.png",
                CategoryId = 2
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 10,
                Title = "Why They Stay",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/58524608._SX300_.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-45.png",
                CategoryId = 2
            });

            //Non-Fiction
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 11,
                Title = "Vengeance Of The Pirate Queen",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/59656615.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-45.png",
                CategoryId = 3
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 12,
                Title = "Betting On You",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/60197314.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-45.png",
                CategoryId = 3
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 13,
                Title = "Check & Mate",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/60683957.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-45.png",
                CategoryId = 3
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 14,
                Title = "Gorgeous Gruesome Faces",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/63005207._SY475_.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-45.png",
                CategoryId = 3
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 15,
                Title = "Gator Country",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/65211796.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-50.png",
                CategoryId = 3
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 16,
                Title = "Mothtown",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/80328993.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-45.png",
                CategoryId = 3
            });

            //Romance
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 17,
                Title = "The Brutal Truth",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/35335134.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-50.png",
                CategoryId = 4
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 18,
                Title = "Shades Of Blue",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/36649339.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-50.png",
                CategoryId = 4
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 19,
                Title = "Chef's Kiss",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/58443037.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-50.png",
                CategoryId = 4
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 20,
                Title = "The Diamond Eye",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/58490567.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-50.png",
                CategoryId = 4
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 21,
                Title = "The Fixer",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/75434345.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-50.png",
                CategoryId = 4
            });

            //Drama
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 22,
                Title = "The Armor Of Light",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/81067992.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-35.png",
                CategoryId = 5
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 23,
                Title = "Swarm",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/86033921.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-45.png",
                CategoryId = 5
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 24,
                Title = "To Free The Captives",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/112974900.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-25.png",
                CategoryId = 5
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 25,
                Title = "The Good Part",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/112976344.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-40.png",
                CategoryId = 5
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 26,
                Title = "Good Girls Don't Die",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/122658643.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-45.png",
                CategoryId = 5
            });

            //Horror
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 27,
                Title = "Where He Can't Find You",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/123262468._SY475_.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-50.png",
                CategoryId = 6
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 28,
                Title = "Ghosts Of Honolulu",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/123266603._SY475_.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-45.png",
                CategoryId = 6
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 29,
                Title = "A City On Mars",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/125084292.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-30.png",
                CategoryId = 6
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 30,
                Title = "The Hijacking Of American Flight 119",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/125423142.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-15.png",
                CategoryId = 6
            });
            modelBuilder.Entity<Book>().HasData(new Book
            {
                Id = 31,
                Title = "A Woman I Know",
                Description = "Lorem, ipsum dolor sit amet consectetur adipisicing elit. Ipsa, itaque tempore autem, ullam vel veritatis laudantium enim officiis nemo quasi, dicta praesentium corrupti minus? Omnis fuga voluptatum deserunt ex ea? Lorem, ipsum dolor sit amet consectetur adipisicing elit. Sed esse non vel, alias fuga pariatur aperiam dolorum numquam tempore possimus, aliquam soluta!",
                ImageUrl = "images/128126768.jpg",
                Price = 250,
                Qty = 120,
                ISBN = "978-3-16-148410-0",
                Rating = "images/ratings/rating-25.png",
                CategoryId = 6
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
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 6,
                AuthorId = 6,
                BookId = 6
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 7,
                AuthorId = 7,
                BookId = 7
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 8,
                AuthorId = 8,
                BookId = 8
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 9,
                AuthorId = 9,
                BookId = 9
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 10,
                AuthorId = 10,
                BookId = 10
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 11,
                AuthorId = 11,
                BookId = 11
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 12,
                AuthorId = 12,
                BookId = 12
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 13,
                AuthorId = 13,
                BookId = 13
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 14,
                AuthorId = 14,
                BookId = 14
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 15,
                AuthorId = 15,
                BookId = 15
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 16,
                AuthorId = 16,
                BookId = 16
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 17,
                AuthorId = 17,
                BookId = 17
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 18,
                AuthorId = 18,
                BookId = 18
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 19,
                AuthorId = 19,
                BookId = 19
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 20,
                AuthorId = 20,
                BookId = 20
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 21,
                AuthorId = 17,
                BookId = 21
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 22,
                AuthorId = 22,
                BookId = 22
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 23,
                AuthorId = 23,
                BookId = 23
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 24,
                AuthorId = 24,
                BookId = 24
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 25,
                AuthorId = 25,
                BookId = 25
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 26,
                AuthorId = 26,
                BookId = 26
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 27,
                AuthorId = 27,
                BookId = 27
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 28,
                AuthorId = 28,
                BookId = 28
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 29,
                AuthorId = 29,
                BookId = 29
            });
            modelBuilder.Entity<BookAuthor>().HasData(new BookAuthor
            {
                Id = 30,
                AuthorId = 30,
                BookId = 30
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
                Name = "Alice ",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 5,
                Name = "Liza Mundy",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 6,
                Name = "Mary Ann Shaffer and Anne Barrows",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 7,
                Name = "Andrea Van Landingham",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 8,
                Name = "Anderson Cooper",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 9,
                Name = "Laurence Leamer",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 10,
                Name = "Anne Michaud",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 11,
                Name = "Tricia Levenseller",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 12,
                Name = "Lynn Painter",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 13,
                Name = "Ali Hazelwood",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 14,
                Name = "Linda Cheng",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 15,
                Name = "Rebeccas Renner",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 16,
                Name = "Caroline Hardaker",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 17,
                Name = "Lee Winter",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 18,
                Name = "Olivia Janae",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 19,
                Name = "Stephanie Shea",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 20,
                Name = "Kate Quinn",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 21,
                Name = "Kent Follett",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 22,
                Name = "Ken Follett",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 23,
                Name = "Jennifer Lyle",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 24,
                Name = "Tracy K. Smith",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 25,
                Name = "Sophie Cousens",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 26,
                Name = "Christina Henry",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 27,
                Name = "Darcy Coates",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 28,
                Name = "Mark Harmon",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 29,
                Name = "Kelly And Zach Weinersmith",
                Biography = "Aliquam! Lorem ipsum dolor sit amet consectetur adipisicing elit. Aperiam ducimus ex delectus! Ipsum quaerat exercitationem expedita placeat. Esse blanditiis, soluta perspiciatis tenetur unde corporis sequi eos cupiditate. Dolores, obcaecati explicabo"
            });
            modelBuilder.Entity<Author>().HasData(new Author
            {
                Id = 30,
                Name = "John Wigger",
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
            modelBuilder.Entity<BookCategory>().HasData(new BookCategory
            {
                Id = 6,
                Genre = "Horror"
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
