
namespace OnlineBookStoreBaird.Models
{
    // This class will hold the repository
    public class EFBookStoreRepository : IBookStoreRepository
    {
        private OnlineBookStoreDBContext _context;
        public EFBookStoreRepository(OnlineBookStoreDBContext temp)
        {
            _context = temp;
        }
        public IQueryable<Book> Books => _context.Books;
    }
}
