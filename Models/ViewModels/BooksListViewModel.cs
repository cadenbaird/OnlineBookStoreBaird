namespace OnlineBookStoreBaird.Models.ViewModels
{
    public class BooksListViewModel
    {
        // Create a public variable to hold the list of books
        public IQueryable<Book> Books { get; set; }
        // Create a public variable to hold the pagination info
        public PaginationInfo PaginationInfo { get; set; } = new PaginationInfo();
    }
}
