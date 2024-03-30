namespace OnlineBookStoreBaird.Models
{
    public interface IBookStoreRepository
    {
        public IQueryable<Book> Books { get; }
    }
}
