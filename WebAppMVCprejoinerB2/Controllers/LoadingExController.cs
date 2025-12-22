using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCprejoinerB2.Controllers
{
    public class LoadingExController : Controller
    {
        public readonly ILoading _rep;

        public LoadingExController(ILoading rep) { 
        _rep = rep; 
        }
        public async Task< IActionResult> Index()
        {
            return View(await _rep.GetAllBooks());
        }
    }
}
