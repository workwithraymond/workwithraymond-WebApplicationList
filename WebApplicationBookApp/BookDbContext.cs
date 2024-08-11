using Microsoft.EntityFrameworkCore;
using WebApplicationBookApp.Models;
using Microsoft.Extensions.Configuration;

namespace WebApplicationBookApp
{
    public class BookDbContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public BookDbContext(DbContextOptions<BookDbContext> options, IConfiguration configuration)
            : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            if (!options.IsConfigured)
            {
                var connectionString = _configuration.GetConnectionString("DefaultConnection");
                options.UseSqlServer(connectionString);
            }
        }

        public DbSet<Book> Books { get; set; }
        public DbSet<Author> Authors { get; set; }
    }
}