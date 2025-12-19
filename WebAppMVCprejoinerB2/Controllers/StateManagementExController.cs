using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCprejoinerB2.Controllers
{

   public class MyData
    {
        public int ID { get; set; }
        public string Name { get; set; }
    }
    public class StateManagementExController : Controller
    {
        public IActionResult From()
        {

            // store the data & retrive

            ViewBag.res = "Some data from viewbag";  // Source  // retrive the only to its action and view
            ViewData["vd"] = "some Data from View data";
            TempData["td"] = "Data from temp data"; // destination of tempdata

            // return View();
            return RedirectToAction("To"); // scope temp data ends

            // View bag  & view data scope --> Only to its corresponding view or action
        }

        public IActionResult To()
        {
            return View();
        }

        public IActionResult Another()
        {
            ViewBag.res = "Some data from viewbag....";  // Source  // retrive the only to its action and view
            ViewData["vd"] = "some Data from View data....";
            return View();
        }


        public IActionResult GetData()
        {

            IList<MyData> obj = new List<MyData>() {
            new MyData{ ID=1,Name="test"},
              new MyData{ ID=2,Name="xyz"},
            };

            //  ViewBag.res = obj;  // comppex data no type casting req
            ViewData["res1"] = obj;
            //TempData["res2"] = obj;
            return View();

        }

        public ActionResult First()
        {
            TempData["Message"] = "Hello User";
            return RedirectToAction("Second");
        }

        public ActionResult Second()
        {
            ViewBag.Msg = TempData["Message"]; // deleting 
            TempData.Keep("Message");
            return View();
        }
        public ActionResult GetDataIntoSession()  
        {
       
            return View();
        }
    }
}
