using Microsoft.EntityFrameworkCore;

namespace OnlineBookStoreBaird.Models
{
    public class OnlineBookStoreDBContext : DbContext
    {
        public OnlineBookStoreDBContext(DbContextOptions<OnlineBookStoreDBContext> options) : base(options) { }

        public DbSet<Book>? Books { get; set; }
    }
}
