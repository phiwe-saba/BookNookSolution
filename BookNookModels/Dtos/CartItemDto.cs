using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNookModels.Dtos
{
    public class CartItemDto
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public int CartId { get; set; }
        public int AuthorId { get; set; }
        public string BookTitle { get; set; }
        public string BookDescription { get; set; }
        public string AuthorsName { get; set; }
        public string ImageUrl { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public decimal TotalPrice { get; set; }
        public int Qty { get; set; }
    }
}
