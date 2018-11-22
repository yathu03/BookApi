using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookAPI.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new BookAPIContext(
                serviceProvider.GetRequiredService<DbContextOptions<BookAPIContext>>()))
            {
                // Look for any movies.
                if (context.BookItem.Count() > 0)
                {
                    return;   // DB has been seeded
                }

                context.BookItem.AddRange(
                    new BookItem
                    {
                        Title = "Harry Potter and the Philospher's Stone",
                        Characters = "Harry Potter, Hermione Granger, Ronald Weasley, Albus Dumbledore, Rubeus Hagrid",
                        PublicationYear = 1997,
                        Description = "The story of a young boy who discovers that he possesses magical powers and must fight off evil",
                        Author = "J. K. Rowling",
                    }


                );
                context.SaveChanges();
            }
        }
    }
}

