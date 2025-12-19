using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCprejoinerB2.Controllers
{
    public class BookController : Controller
    {
        public readonly IBookRepo _rep;
        public BookController(IBookRepo rep)
        {
            _rep = rep;
        }

        public async Task<IActionResult> BookList()
        {
            return View(await _rep.GetAllBooks());   // D
        }

        public async Task<IActionResult> EditBook(int BookID)
        {
            return View(await _rep.GetDataBookByID(BookID));
        }
    }
}
