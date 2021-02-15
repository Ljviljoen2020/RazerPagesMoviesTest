using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;
using RazorPagesMoviesTest.Data;

namespace RazorPagesMoviesTest.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly RazorPagesMoviesTest.Data.RazorPagesMoviesTestContext _context;

        public IndexModel(RazorPagesMoviesTest.Data.RazorPagesMoviesTestContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
