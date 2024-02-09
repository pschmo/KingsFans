 using Microsoft.AspNetCore.Mvc;
using Mission5_Schmoekel.Models;
using System.Diagnostics;

namespace Mission5_Schmoekel.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("calculator")]
        public IActionResult Calculator()
        {
            // Set the HourlyRate value in ViewBag
            ViewBag.HourlyRate = 55.0; // Replace with your actual hourly rate

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
