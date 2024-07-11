namespace BookNookApi.Entities
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string ISBN { get; set; }
        public string Description { get; set; }
        public string ImageUrl  { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; } 
        public string Rating { get; set; }
        public int CategoryId { get; set; }
    }
}
