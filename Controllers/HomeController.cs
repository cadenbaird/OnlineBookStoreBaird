using Microsoft.AspNetCore.Mvc;
using OnlineBookStoreBaird.Models;
using OnlineBookStoreBaird.Models.ViewModels;
using SQLitePCL;
using System.Diagnostics;



namespace OnlineBookStoreBaird.Controllers
{
    public class HomeController : Controller
    {
        // Create a private variable to hold the repository
        private IBookStoreRepository _bookrepo;

        public HomeController(IBookStoreRepository temp)
        {
            _bookrepo = temp;
        }
        
        public IActionResult Index(int pageNum)
        {
            int pageSize = 10;

            // If pageNum is null, set it to 1
            var blah = new BooksListViewModel
            {
                Books = _bookrepo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),
                // Pagination info
                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookrepo.Books.Count()
                }

            };

            // Return the view with the list of books
            return View(blah);
        }
    }
}
