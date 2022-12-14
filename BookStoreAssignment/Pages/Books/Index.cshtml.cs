using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using BookStoreAssignment.Data;
using BookStoreAssignment.Models;

namespace BookStoreAssignment.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly BookStoreAssignment.Data.BookStoreAssignmentContext _context;

        public IndexModel(BookStoreAssignment.Data.BookStoreAssignmentContext context)
        {
            _context = context;
        }

        public IList<Book> Book { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Book != null)
            {
                Book = await _context.Book.ToListAsync();
            }
        }
    }
}
