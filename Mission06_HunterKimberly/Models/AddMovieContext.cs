using Microsoft.EntityFrameworkCore;

namespace Mission06_HunterKimberly.Models
{
    public class AddMovieContext : DbContext
    {
        public AddMovieContext(DbContextOptions<AddMovieContext> options) : base (options)
        {
        }

        public DbSet<Movie> Movies { get; set; }
    }
}


