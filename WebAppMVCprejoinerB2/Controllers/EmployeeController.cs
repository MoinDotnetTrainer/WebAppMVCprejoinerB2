using DAL.Interfaces;
using DAL.Models;
using Microsoft.AspNetCore.Mvc;
using WebAppMVCprejoinerB2.Models;

namespace WebAppMVCprejoinerB2.Controllers
{
    [SetSession]
    public class EmployeeController : Controller
    {
        public readonly IEmpRepo _rep;
        public EmployeeController(IEmpRepo rep)
        {
            _rep = rep;
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();   // View Add
        }

        [HttpPost]
        public IActionResult Add(Cal obj)
        {
            int z = obj.x + obj.y;
            TempData["res"] = z;
            return View();   // View Add
        }

        [HttpGet]
        public IActionResult AddEmp()
        {
            return View();   // View Add
        }

        [HttpPost]
        public async Task<IActionResult> AddEmp(Employee obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }
            await _rep.AddEmp(obj);

            return RedirectToAction("EmployeeList");   // View Add
        }

        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            return View(await _rep.GetAllData());   // D
        }


        [HttpGet]
        public async Task<IActionResult> EditEmp(int Eid)
        {
            return View(await _rep.GetDataByID(Eid));
        }

        [HttpPost]
        public async Task<IActionResult> EditEmp(Employee obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }
            await _rep.UpdateEmp(obj);

            return RedirectToAction("EmployeeList");   // View Add
        }


        [HttpGet]
        public async Task<IActionResult> DeleteEmp(int Eid)
        {
            return View(await _rep.GetDataByID(Eid));
        }

        [HttpPost]
        public async Task<IActionResult> DeleteEmp(Employee obj)
        {
            if (obj == null)
            {
                return BadRequest();
            }
            await _rep.DeleteEmp(obj.Eid);

            return RedirectToAction("EmployeeList");   // View Add
        }




    }
}
