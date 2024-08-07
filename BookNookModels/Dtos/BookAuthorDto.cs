﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookNookModels.Dtos
{
    public class BookAuthorDto
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string ISBN { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public string Rating { get; set; }
        public int CategoryId { get; set; }
        public string CategoryGenre { get; set; }
        public int AuthorId { get; set; }
        public string AuthorName { get; set; }

    }
}
