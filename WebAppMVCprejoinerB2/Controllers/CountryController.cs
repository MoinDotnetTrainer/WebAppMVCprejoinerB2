using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCprejoinerB2.Controllers
{
    public class CountryController : Controller
    {
        public readonly IOneToMany _rep;
        public CountryController(IOneToMany rep)
        {
            _rep = rep;
        }
        public async Task< IActionResult> Countries()
        {
            return View(await _rep.GetCountries());
        }
    }
}
