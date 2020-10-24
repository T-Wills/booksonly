using JustBooks.Data.Interfaces;
using JustBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Data.Repositories
{
    public class GenreRepository : IGenreRepository
    {
        private AppDbContext _appDbContext;

        public GenreRepository(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public IEnumerable<Genre> Genre => _appDbContext.Genre;
    }
}
