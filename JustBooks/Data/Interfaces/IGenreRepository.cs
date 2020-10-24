using JustBooks.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Data.Interfaces
{
    public interface IGenreRepository
    {
        IEnumerable<Genre> Genre { get; }
    }
}
