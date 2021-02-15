
using Microsoft.EntityFrameworkCore;
using RazorPagesMovie.Models;

namespace RazorPagesMoviesTest.Data
{
    public class RazorPagesMoviesTestContext : DbContext
    {
        public RazorPagesMoviesTestContext (DbContextOptions<RazorPagesMoviesTestContext> options)
            : base(options)
        {
        }

        public DbSet<RazorPagesMovie.Models.Movie> Movie { get; set; }
    }
}
