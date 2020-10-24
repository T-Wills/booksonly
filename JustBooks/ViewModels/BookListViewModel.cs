using JustBooks.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.ViewModels
{
    public class BookListViewModel
    {
      public IEnumerable<Book> Books { get; set; }
      public string CurrentGenre { get; set; }
    }
}
