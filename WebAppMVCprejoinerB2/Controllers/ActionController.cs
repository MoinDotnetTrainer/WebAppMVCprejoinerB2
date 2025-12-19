using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using WebAppMVCprejoinerB2.Models;

namespace WebAppMVCprejoinerB2.Controllers
{
    public class ActionController : Controller
    {
        public readonly ILogin _rep;
        public ActionController(ILogin rep)
        {
            _rep = rep;
        }

        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Login(LoginModel obj)
        {
            if (obj == null)
            {
                return View();
            }
            bool res = _rep.AuthenticateUser(obj);
            if (res)
            {

                return RedirectToAction("HomePage");
            }
            else
            {
                TempData["res"] = "Email or password is not corerct";
                return View();
            }

        }

        [HttpGet]
        public IActionResult Homepage()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Validations_Ex()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Validations_Ex(Movies obj)
        {
            if (ModelState.IsValid)
            {
                TempData["res"] = " All Good";
            }
            else
            {
                TempData["res"] = "Data Required";
            }
            return View();
        }

        [HttpGet]
        public IActionResult Launch()
        {
            string str = null;
            
            TempData["res"] = str.Length; // run time error
            
            return View();
        }
    }
}
