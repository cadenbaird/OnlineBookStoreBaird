namespace OnlineBookStoreBaird.Models
{
    // This interface will hold the repository
    public interface IBookStoreRepository
    {
        // Create a public variable to hold the list of books
        public IQueryable<Book> Books { get; }
    }
}
