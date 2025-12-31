using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace WebAppMVCprejoinerB2.Controllers
{

    public class TasksController : Controller
    {
        public readonly ITaskInterface _itask;
        public readonly IUserInterface _iuser;
        public TasksController(ITaskInterface itask, IUserInterface iuser)
        {
            _itask = itask;
            _iuser = iuser;
        }

        [HttpGet]
        public async Task<IActionResult> AddTask()
        {
            ViewBag.res = new SelectList(await _iuser.GetAllUsers(), "UserId", "Username"); // second is for UI
            return View();
        }

        [HttpPost]

        public async Task<IActionResult> AddTask(UsersTask obj)
        {
            if (ModelState.IsValid)
            {
                await _itask.InsertUsersTask(obj);
                await _iuser.SaveAsync();
            }
            TempData["res"] = "some thing went wrong";
            return View();

        }

        [HttpGet]
        public async Task<IActionResult> TaskList()
        {
            var res = await _itask.GetAllUsersTask();
            return View(res);
        }

        [HttpGet]
        public async Task<IActionResult> Edittask(int TaskId)
        {
            if (TaskId == null)
            {
                return NotFound();
            }
            var res = await _itask.GetUsersTaskbyID(TaskId);
            if (res == null)
            {
                return NotFound();
            }

            ViewBag.res = new SelectList(await _iuser.GetAllUsers(), "UserId", "UserName");
            return View(res);
        }

        [HttpPost]
        public async Task<IActionResult> Edittask(UsersTask obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }

            try
            {
                await _itask.UpdateUsersTask(obj);
                await _itask.SaveAsync();
            }
            catch (DbUpdateConcurrencyException ex)
            {

                throw ex;
            }

            return RedirectToAction("TaskList");
        }
    }
}
