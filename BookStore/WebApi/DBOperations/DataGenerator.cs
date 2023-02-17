using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

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