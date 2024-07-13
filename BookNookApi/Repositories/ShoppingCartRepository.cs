using BookNookApi.Data;
using BookNookApi.Entities;
using BookNookApi.Repositories.Contracts;
using BookNookModels.Dtos;
using Microsoft.EntityFrameworkCore;

namespace BookNookApi.Repositories
{
    public class ShoppingCartRepository : IShoppingCartRepository
    {
        private BookNookDbContext bookNookDbContext;
        public ShoppingCartRepository(BookNookDbContext bookNookDbContext)
        {
            this.bookNookDbContext = bookNookDbContext;
        }
        private async Task<bool> CartItemExists(int cartId, int bookId)
        {
            return await this.bookNookDbContext.CartItems.AnyAsync(c => c.CartId == cartId &&
                                                                   c.BookId == bookId);
        }
        public async Task<CartItem> AddItem(CartItemToAddDto cartItemToAddDto)
        {
            if (await CartItemExists(cartItemToAddDto.CartId, cartItemToAddDto.BookId) == false)
            {
                var item = await (from book in this.bookNookDbContext.Books
                                  where book.Id == cartItemToAddDto.BookId
                                  select new CartItem
                                  {
                                      CartId = cartItemToAddDto.CartId,
                                      BookId = book.Id,
                                      Qty = cartItemToAddDto.Qty
                                  }).SingleOrDefaultAsync();

                if (item != null)
                {
                    var result = await this.bookNookDbContext.CartItems.AddAsync(item);
                    await this.bookNookDbContext.SaveChangesAsync();
                    return result.Entity;
                }
            }

            return null;
        }

        public Task<CartItem> DeleteItem(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<CartItem> GetItem(int id)
        {
            return await (from cart in this.bookNookDbContext.Carts
                          join cartItem in this.bookNookDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cartItem.Id == id
                          select new CartItem
                          {
                              Id = cart.Id,
                              BookId = cartItem.BookId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).SingleOrDefaultAsync();
        }

        public async Task<IEnumerable<CartItem>> GetItems(int userId)
        {
            return await (from cart in this.bookNookDbContext.Carts
                          join cartItem in this.bookNookDbContext.CartItems
                          on cart.Id equals cartItem.CartId
                          where cart.UserId == userId
                          select new CartItem
                          {
                              Id = cartItem.Id,
                              BookId = cartItem.BookId,
                              Qty = cartItem.Qty,
                              CartId = cartItem.CartId
                          }).ToListAsync();
        }

        public Task<CartItem> UpdateQty(int id, CartItemQtyUpdateDto cartItemQtyUpdateDto)
        {
            throw new NotImplementedException();
        }
    }
}
