using JustBooks.Data.Interfaces;
using JustBooks.Models;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Data.Mocks
{
    public class MockBookRepository : IBookRepository
    {
        private readonly IGenreRepository _genreRepository = new MockGenreRepository();

        public IEnumerable<Book> Books {
            get
            {
                return new List<Book>
                {
                     new Book
                    {
                        Title = "Think Big",
                        Author = "Ben Carson",
                        Image="",
                        Genre=_genreRepository.Genre.First(),
                        GenreType = "Biography",
                        About="Transforming your life into one you'll love, bigger than you've ever dreamed.",
                        Price=7000,
                        InStock=true,
                        IsPreferredBook=true,
                        ImageThumbnail="",
                    },

                     new Book
                     {
                        Title = "The Only Wise God",
                        Author = "William Lane Craig",
                        Image="",
                        Genre=_genreRepository.Genre.First(),
                        GenreType = "Religious",
                        About="A wonderful and comforting book about the true nature of God. He knows us completely, allows us complete freedom to choose to follow Him or not.",
                        Price=5000,
                        InStock=true,
                        IsPreferredBook=true
                     },

                      new Book
                      {
                        Title = "80-20 Pareto Principle",
                        Author = "Richard Koch",
                        Image="",
                        Genre=_genreRepository.Genre.First(),
                        GenreType = "Business",
                        About="The 80/20 principle is one of the great secrets of highly effective people and organizations.",
                        Price=5000,
                        InStock=true,
                        IsPreferredBook=true
                      },

                       new Book
                       {
                        Title = "Purpose Driven Life",
                        Author = "Rick Warren",
                        Image="",
                        Genre=_genreRepository.Genre.First(),
                        GenreType = "Christian Literature",
                        About="The Purpose Driven Life is a bible study book written by Christian pastor Rick Warren and published by Zondervan in 2002. " +
                              "The book offers readers a 40-day personal spiritual journey and presents what Warren says are God's five purposes for human life on Earth.",
                        Price=6000,
                        InStock=true,
                        IsPreferredBook=true
                       },

                        new Book
                        {
                           Title = "The Lean Start-Up",
                           Author = "Eric Ries",
                           Image="",
                           Genre=_genreRepository.Genre.First(),
                           GenreType = "Business",
                           About="The book offers a systematic, scientific way for business managers to get the information they need to make fast decisions in today’s changing world.",
                           Price=5500,
                           InStock=true,
                           IsPreferredBook=true
                        },

                        new Book
                        {
                           Title = "Rich Dad, Poor Dad",
                           Author = "Robert.T.Kiyosaki",
                           Image="",
                           Genre=_genreRepository.Genre.First(),
                           GenreType = "Business",
                           About="Rich Dad Poor Dad is about Robert Kiyosaki and his two dads—his real father (poor dad) and the father of his best friend (rich dad)—and the ways in which both men shaped his thoughts about money and investing.",
                           Price=8000,
                           InStock=true,
                           IsPreferredBook=true
                        },

                        new Book
                        {
                           Title = "Why You Act The Way You Do",
                           Author = "Tim Lahaye",
                           Image="",
                           Genre=_genreRepository.Genre.First(),
                           GenreType = "Religious",
                           About="Readers discover how temperament affects their work, emotions, spiritual life, and relationships and learn how to make improvements.",
                           Price=6500,
                           InStock=true,
                           IsPreferredBook=true
                        },

                        new Book
                        {
                           Title = "Tha fault in our stars",
                           Author = "John Green",
                           Image = "",
                           Genre = _genreRepository.Genre.First(),
                           GenreType = "Romance",
                           About = "The story is narrated by Hazel Grace Lancaster, a 16-year-old girl with thyroid cancer that has affected her lungs.",
                           Price = 3000,
                           InStock = true,
                           IsPreferredBook = true
                        }

                };


            }

        }
        public IEnumerable<Book> PreferredBooks { get; set; }
       

        public Book GetBookById(int BookId)
        {
            throw new NotImplementedException();
        }
    }
}
