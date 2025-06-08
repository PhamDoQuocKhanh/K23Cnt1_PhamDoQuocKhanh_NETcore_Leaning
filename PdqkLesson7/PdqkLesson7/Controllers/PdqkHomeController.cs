using Microsoft.AspNetCore.Mvc;
using PdqkLesson7.Models;
using System.Diagnostics;

namespace PdqkLesson7.Controllers
{
    public class PdqkHomeController : Controller
    {
        private readonly ILogger<PdqkHomeController> _logger;

        public PdqkHomeController(ILogger<PdqkHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PdqkIndex()
        {
            return View();
        }

        public IActionResult PdqkAbout()
        {
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
