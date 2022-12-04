using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BookStoreAssignment.Models;

namespace BookStoreAssignment.Data
{
    public class BookStoreAssignmentContext : DbContext
    {
        public BookStoreAssignmentContext (DbContextOptions<BookStoreAssignmentContext> options)
            : base(options)
        {
        }

        public DbSet<BookStoreAssignment.Models.Book> Book { get; set; } = default!;
    }
}
