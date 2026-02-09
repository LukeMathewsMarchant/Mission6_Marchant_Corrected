using Microsoft.EntityFrameworkCore;

namespace Mission6.Models;
//Context file to help connect the database
public class MoviesContext : DbContext
{
    public MoviesContext(DbContextOptions<MoviesContext> options) : base (options)
    {
        
    }
    public DbSet<Movie> Movies { get; set; }
}