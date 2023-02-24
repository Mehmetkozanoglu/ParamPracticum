using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using WebApi.Entities;

namespace WebApi.DBOperations
{
    public class DataGenerator
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
        using (var context = new BookStoreDbContext(serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
        {
            if (context.Books.Any())
            {
               return;
            }
            context.Authors.AddRange(
                    new Author{
                    Name = "Onur",
                    SurName ="Koca",
                    DateOfBirth = new DateTime(1996,01,01),
                    BookId = 1

                    },
                    new Author{
                    Name = "Mehmet",
                    SurName = "Kozanoğlu",
                    DateOfBirth = new DateTime(1996,06,12),
                    BookId = 2
                    },
                    new Author{
                    Name = "Mali",
                    SurName ="Zorba",
                    DateOfBirth = new DateTime(1996,03,24),
                    BookId = 3
                    }
                );
            context.Genres.AddRange(
               new Genre{
                  Name = "Personal Growth"
               },
               new Genre{
                  Name = "Science Fiction"
               },
               new Genre{
                  Name = "Romance"
               }
            );
            context.Books.AddRange(
            new Book
            {
               // Id = 1,
               Title = "Lean Startup",
               GenreId = 1,
               PageCount = 200,
               PublishDate = new DateTime(1996,06,12)
            },
            new Book{
               // Id = 2,
               Title = "HerLand",
               GenreId = 2,
               PageCount = 250,
               PublishDate = new DateTime(2000,01,11)
            },
            new Book{
               // Id = 3,
               Title = "Dune",
               GenreId = 2,
               PageCount = 300,
               PublishDate = new DateTime(2005,02,03)
            }
               );
               context.SaveChanges();             
            }
        }
    }
}