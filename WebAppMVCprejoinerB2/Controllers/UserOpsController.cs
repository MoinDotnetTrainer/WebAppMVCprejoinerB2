using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCprejoinerB2.Controllers
{

    public class UserOpsController : Controller
    {
        public readonly IUserInterface _iuser;
        public UserOpsController(IUserInterface iuser)
        {
            _iuser = iuser;
        }

        [HttpGet]
        public async Task<IActionResult> UsersList()
        {

            // we dont write get logic , ibsted will call a method from Iuserclass repo
            var res = await _iuser.GetAllUsers();
            return View(res);
        }


        [HttpGet]
        public IActionResult CreateUsers()
        {

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateUsers(Users data)
        {
            if (ModelState.IsValid) // verifies that it is passing all my validation , bool
            {
                await _iuser.InsertUser(data);
                await _iuser.SaveAsync();
                return RedirectToAction("Userlogin");
            }
            return View(data);
        }


        [HttpGet]
        public async Task<IActionResult> EditUsers(int UserId)
        {
            if (UserId == null)
            {
                return NotFound();
            }
            var res = await _iuser.GetUserbyID(UserId);

            return View(res);
        }

        [HttpPost]
        public IActionResult EditUsers(Users obj)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _iuser.UpdateUsers(obj);
                    _iuser.SaveAsync();
                    return RedirectToAction("UsersList");
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> DeleteUsers(int UserId)
        {
            var res = await _iuser.GetUserbyID(UserId);
            return View(res);
        }

        [HttpPost, ActionName("DeleteUsers")]
        public async Task<IActionResult> DeleteConfirm(int UserId)
        {
            if (UserId == null)
            {
                return NotFound();
            }
            else
            {
                await _iuser.DeleteUsers(UserId);
                _iuser.SaveAsync();
                return RedirectToAction("Userslist");
            }
        }


        [HttpGet]
        public async Task<IActionResult> UserDetails(int UserId)
        {
            var res = await _iuser.GetUserbyID(UserId);
            return View(res);
        }


        [HttpGet]
        public IActionResult UserLogin()
        {

            return View();
        }


        [HttpPost]
        public IActionResult UserLogin(LoginModel obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }
            var res = _iuser.Login(obj);
            if (res)
            {
                return RedirectToAction("UsersList");
            }
            TempData["res"] = "Email or password is not correct!";
            return View();
        }


    }
}
