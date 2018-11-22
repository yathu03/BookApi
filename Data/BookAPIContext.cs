using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace BookAPI.Models
{
    public class BookAPIContext : DbContext
    {
        public BookAPIContext (DbContextOptions<BookAPIContext> options)
            : base(options)
        {
        }

        public DbSet<BookAPI.Models.BookItem> BookItem { get; set; }
    }
}
