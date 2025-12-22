using DAL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace WebAppMVCprejoinerB2.Controllers
{
    public class CityPinController : Controller
    {
        public readonly ICityPin _cityPin;
        public CityPinController(ICityPin citypin)
        {
            _cityPin = citypin;
        }
        public async Task< IActionResult> City()
        {
            return View(await _cityPin.GetCity());
        }

        public async Task< IActionResult> Pin()
        {
            return View(await _cityPin.GetPin());
        }
    }
}
