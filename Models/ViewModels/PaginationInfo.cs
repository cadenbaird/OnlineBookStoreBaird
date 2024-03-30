namespace OnlineBookStoreBaird.Models.ViewModels
{
    // This class will hold the pagination information
    public class PaginationInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int) (Math.Ceiling((decimal) TotalItems / ItemsPerPage));
    }
}
