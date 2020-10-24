using JustBooks.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JustBooks.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {

            using (var context = new AppDbContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<AppDbContext>>()))
            {
                

                if (!context.Genre.Any())
                {
                    context.Genre.AddRange(Genre.Select(g => g.Value));
                }
                if (context.Books.Any())
                {
                    return;
                }
                    context.Books.AddRange(
                         new Book
                         {
                             Title = "Think Big",
                             Author = "Ben Carson",
                             Image = "",
                             Genre = Genre["Non-Fiction"],
                             GenreType = "Biography",
                             About = "Transforming your life into one you'll love, bigger than you've ever dreamed.",
                             Price = 7000,
                             InStock = true,
                             IsPreferredBook = true,
                         },

                         new Book
                         {
                             Title = "The Only Wise God",
                             Author = "William Lane Craig",
                             Image = "",
                             Genre = Genre["Non-Fiction"],
                             GenreType = "Religious",
                             About = "A wonderful and comforting book about the true nature of God. He knows us completely, allows us complete freedom to choose to follow Him or not.",
                             Price = 5000,
                             InStock = true,
                             IsPreferredBook = true
                         },

                          new Book
                          {
                              Title = "80-20 Pareto Principle",
                              Author = "Richard Koch",
                              Image = "",
                              Genre = Genre["Non-Fiction"],
                              GenreType = "Business",
                              About = "The 80/20 principle is one of the great secrets of highly effective people and organizations.",
                              Price = 5000,
                              InStock = true,
                              IsPreferredBook = true
                          },

                           new Book
                           {
                               Title = "Purpose Driven Life",
                               Author = "Rick Warren",
                               Image = "",
                               Genre = Genre["Non-Fiction"],
                               GenreType = "Christian Literature",
                               About = "The Purpose Driven Life is a bible study book written by Christian pastor Rick Warren and published by Zondervan in 2002. " +
                                  "The book offers readers a 40-day personal spiritual journey and presents what Warren says are God's five purposes for human life on Earth.",
                               Price = 6000,
                               InStock = true,
                               IsPreferredBook = true
                           },

                            new Book
                            {
                                Title = "The Lean Start-Up",
                                Author = "Eric Ries",
                                Image = "",
                                Genre = Genre["Non-Fiction"],
                                GenreType = "Business",
                                About = "The book offers a systematic, scientific way for business managers to get the information they need to make fast decisions in today’s changing world.",
                                Price = 5500,
                                InStock = true,
                                IsPreferredBook = true
                            },

                            new Book
                            {
                                Title = "Rich Dad, Poor Dad",
                                Author = "Robert.T.Kiyosaki",
                                Image = "",
                                Genre = Genre["Non-Fiction"],
                                GenreType = "Business",
                                About = "Rich Dad Poor Dad is about Robert Kiyosaki and his two dads—his real father (poor dad) and the father of his best friend (rich dad)—and the ways in which both men shaped his thoughts about money and investing.",
                                Price = 8000,
                                InStock = true,
                                IsPreferredBook = true
                            },

                            new Book
                            {
                                Title = "Why You Act The Way You Do",
                                Author = "Tim Lahaye",
                                Image = "",
                                Genre = Genre["Non-Fiction"],
                                GenreType = "Religious",
                                About = "Readers discover how temperament affects their work, emotions, spiritual life, and relationships and learn how to make improvements.",
                                Price = 6500,
                                InStock = true,
                                IsPreferredBook = true
                            },

                             new Book
                             {
                                 Title = "Tha fault in our stars",
                                 Author = "John Green",
                                 Image = "",
                                 Genre = Genre["Fiction"],
                                 GenreType = "Romance",
                                 About = "The story is narrated by Hazel Grace Lancaster, a 16-year-old girl with thyroid cancer that has affected her lungs.",
                                 Price = 3000,
                                 InStock = true,
                                 IsPreferredBook = true
                             }
                    );
             
                context.SaveChanges();
            }
        }

        private static Dictionary<string, Genre> genres;
        public static Dictionary<string, Genre> Genre
        {
            get
            {
                if (genres == null)
                {
                    var genreList = new Genre[]
                    {
                        new Genre { GenreName = "Fiction", Description="All Fictional Books" },
                        new Genre { GenreName = "Non-Fiction", Description="All Non-fictional Books" }
                    };

                    genres = new Dictionary<string, Genre>();

                    foreach (Genre category in genreList)
                    {
                        genres.Add(category.GenreName, category);
                    }
                }
                return genres;
            }
        }
    }
}

