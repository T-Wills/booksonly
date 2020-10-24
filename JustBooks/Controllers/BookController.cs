using JustBooks.Data;
using JustBooks.Data.Interfaces;
using JustBooks.Models;
using JustBooks.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Controllers
{
    public class BookController:Controller
    {
        private readonly IGenreRepository _genreRepository;
        private readonly IBookRepository _bookRepository;
       
        /*private IGenreRepository _genreRepository;
        private IBookRepository _bookRepository;*/

        public BookController(IGenreRepository genreRepository, IBookRepository bookRepository)
        {
            _genreRepository = genreRepository;
            _bookRepository = bookRepository;
          
        }

        public ViewResult List()
        {
            ViewBag.Name = "DotNet, How?";
            BookListViewModel vm = new BookListViewModel();
            vm.Books = _bookRepository.Books;
            vm.CurrentGenre = "BookGenre";
            return View(vm);
        }
    }
}
