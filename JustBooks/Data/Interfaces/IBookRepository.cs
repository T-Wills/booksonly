using JustBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Data.Interfaces
{
    public interface IBookRepository
    {
        IEnumerable<Book> Books { get; }
        IEnumerable<Book> PreferredBooks { get; }

        Book GetBookById(int BookId);
    }
}
