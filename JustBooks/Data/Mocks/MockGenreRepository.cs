using JustBooks.Data.Interfaces;
using JustBooks.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Data.Mocks
{
    public class MockGenreRepository:IGenreRepository
    {
       public IEnumerable<Genre> Genre {

            get
            {
                return new List<Genre>
                {
                    new Genre {GenreName = "Fiction", Description = "All Fictional Books" },
                    new Genre {GenreName = "Non-Fiction", Description = "All Non-Fictional Books" }
                };
            }
                
                
        }
        
            
    }
}
