using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCprejoinerB2.Controllers
{
    public class OnetooneExampleController : Controller
    {
        public readonly IOneToone _rep;
        public OnetooneExampleController(IOneToone rep)
        {
            _rep = rep;
        }
        public async Task<IActionResult> Users()
        {

            return View(await _rep.GetUserData());
        }

        public async Task<IActionResult> Userprofile()
        {

            return View(await _rep.GetUserProfileData());
        }
    }
}
