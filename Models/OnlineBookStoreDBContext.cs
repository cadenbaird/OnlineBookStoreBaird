using Microsoft.EntityFrameworkCore;

namespace OnlineBookStoreBaird.Models
{
    // This class will hold the database context
    public class OnlineBookStoreDBContext : DbContext
    {
        // This constructor will take in the options for the database context
        public OnlineBookStoreDBContext(DbContextOptions<OnlineBookStoreDBContext> options) : base(options) { }
        // This public variable will hold the list of books
        public DbSet<Book>? Books { get; set; }
    }
}
