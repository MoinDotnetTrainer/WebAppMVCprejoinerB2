using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCprejoinerB2.Controllers
{
    //[Route("MyController/[action]")]  // url

    //[Route("MyController")]  // url

    // [Route("[controller]/[action]")]
    [Route("[controller]")]

    public class dfsdgdfhfghController : Controller
    {

       [Route("GetAllData/{id?}")]
        public ViewResult Index(int id)
        {
            return View();
            
        }
    }
}
