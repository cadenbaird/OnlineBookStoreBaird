using Microsoft.AspNetCore.Mvc;
using OnlineBookStoreBaird.Models;
using OnlineBookStoreBaird.Models.ViewModels;
using SQLitePCL;
using System.Diagnostics;

namespace OnlineBookStoreBaird.Controllers
{
    public class HomeController : Controller
    {
        private IBookStoreRepository _bookrepo;

        public HomeController(IBookStoreRepository temp)
        {
            _bookrepo = temp;
        }

        public IActionResult Index(int pageNum)
        {
            int pageSize = 5;

            var blah = new BooksListViewModel
            {
                Books = _bookrepo.Books
                .OrderBy(x => x.Title)
                .Skip((pageNum - 1) * pageSize)
                .Take(pageSize),

                PaginationInfo = new PaginationInfo
                {
                    CurrentPage = pageNum,
                    ItemsPerPage = pageSize,
                    TotalItems = _bookrepo.Books.Count()
                }

            };


            return View(blah);
        }
    }
}
