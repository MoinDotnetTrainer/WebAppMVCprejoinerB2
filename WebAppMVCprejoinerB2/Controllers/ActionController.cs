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
                HttpContext.Session.SetString("UserEmail", obj.Email); // here 
                HttpContext.Session.SetString("LoginTime", System.DateTime.Now.ToLongTimeString());

                return RedirectToAction("HomePage");
            }
            else
            {
                TempData["res"] = "Email or password is not corerct";
                return View();
            }

        }


        [SetSession]
        [HttpGet]
        public IActionResult Homepage()
        {
            ViewBag.email = HttpContext.Session.GetString("UserEmail");
            ViewBag.time = HttpContext.Session.GetString("LoginTime");
            return View();
        }

        [SetSession]

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


        [SetSession]
        [HttpGet]
        public IActionResult Launch()
        {
            string str = null;

            TempData["res"] = str.Length; // run time error

            return View();
        }


        [SetSession]
        public IActionResult UseAdminLayout()
        {

            return View();
        }



        [SetSession]
        [HttpGet]
        public IActionResult DataAnnotations()
        {
            return View();
        }
 

        [HttpPost]
        public IActionResult DataAnnotations(ValidateModel obj)
        {
            if (ModelState.IsValid)  // validate the state of Ur model prop
            {
                return View();
            }
            return View();
        }

        [HttpGet]
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Login");
        }
    }
}
