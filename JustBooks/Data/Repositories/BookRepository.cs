using JustBooks.Data.Interfaces;
using JustBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace JustBooks.Data.Repositories
{
    public class BookRepository : IBookRepository
    {
        private readonly AppDbContext _appDbContext;
        private int bookId;

        public BookRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Book> Books => _appDbContext.Books.Include(g => g.Genre);

        public IEnumerable<Book> PreferredBooks => _appDbContext.Books.Where(p => p.IsPreferredBook).Include(g => g.Genre);
        public Book GetBookById(int BookId) => _appDbContext.Books.FirstOrDefault(p => p.BookId == bookId);
    }
}
