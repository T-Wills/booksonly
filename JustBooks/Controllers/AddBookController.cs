using JustBooks.Data;
using JustBooks.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis.Operations;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Controllers
{
    public class AddBookController:Controller
    {
        private readonly AppDbContext _appDbContext;
        private readonly IWebHostEnvironment _iwebhost;
        public AddBookController(AppDbContext appDbContext, IWebHostEnvironment iwebhost)
        {
            _appDbContext = appDbContext;
            _iwebhost = iwebhost;
        }

        public IActionResult Addbooks()
        {
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> Addbooks(BooksViewModel model, Book book)
        {
            string uniqueFileName = UploadedFile(model);
            //adding info from viewmodel to model

            book.Title = model.Title;
            book.Author = model.Author;
            book.Genre = model.Genre;
            book.Price = model.Price;
            book.IsPreferredBook = model.IsPreferredBook;
            book.Image = uniqueFileName;

            //save to database
             _appDbContext.Add(book);
            await _appDbContext.SaveChangesAsync();
            return Redirect("/Book/List");

        }
        private string UploadedFile(BooksViewModel model)
        {
            string uniqueFileName = null;
            
            if (model.Image != null)
            {
                string uploadToFolder = Path.Combine(_iwebhost.WebRootPath, "Imgs");
                //get unique identifier of file
                uniqueFileName = Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                //declare file path
                string filePath = Path.Combine(uploadToFolder, uniqueFileName);

                using(var fileStream  = new FileStream(filePath, FileMode.Create))
                {
                    model.Image.CopyToAsync(fileStream);
                }
            }
            return uniqueFileName;
        }
    }

}
