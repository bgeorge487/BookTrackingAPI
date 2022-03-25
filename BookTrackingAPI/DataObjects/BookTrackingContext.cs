using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BookTrackingAPI.DataObjects
{
    public class BookTrackingContext : DbContext
    {
        public DbSet<Author> Authors { get; set; }

        public DbSet<Book> Books { get; set; }

        public DbSet<BooksAndAuthors> BooksAndAuthors { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json", optional: false);
            var configuration = builder.Build();
            string connectionString = configuration.GetConnectionString("DefautConnection");
            optionsBuilder.UseSqlServer(connectionString);
        }

    }
}
