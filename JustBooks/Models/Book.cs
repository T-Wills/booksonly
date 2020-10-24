using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Models
{
    public class Book
    {
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public string GenreType { get; set; }
        public string Image { get; set; }
        public string ImageThumbnail { get; set; }
        public bool IsPreferredBook { get; set; }
        public string About { get; set; }
        public decimal Price { get; set; }
        public bool InStock { get; set; } 
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
    }
}
