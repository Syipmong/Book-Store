using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using bookstore.Models;
using System;
using System.Linq;
using bookstore.Data;

namespace OnlineBookstore.Data
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookStoreDbContext(
                serviceProvider.GetRequiredService<DbContextOptions<BookStoreDbContext>>()))
            {
                // Look for any books.
                if (context.Books.Any())
                {
                    return;   // DB has been seeded
                }

                context.Books.AddRange(
                    new Book
                    {
                        Title = "The Catcher in the Rye",
                        Author = "J.D. Salinger",
                        Description = "A story about teenage angst and rebellion.",
                        Price = 9.99m,
                        ISBN = "978-0-316-76948-0",
                        Genre = "Fiction",
                        Publisher = "Little, Brown and Company",
                        PublishDate = new DateTime(1951, 7, 16)
                    },
                    new Book
                    {
                        Title = "To Kill a Mockingbird",
                        Author = "Harper Lee",
                        Description = "A novel about the serious issues of rape and racial inequality.",
                        Price = 7.99m,
                        ISBN = "978-0-06-112008-4",
                        Genre = "Fiction",
                        Publisher = "J.B. Lippincott & Co.",
                        PublishDate = new DateTime(1960, 7, 11)
                    }
                    // Add more books here
                );

                context.SaveChanges();
            }
        }
    }
}
