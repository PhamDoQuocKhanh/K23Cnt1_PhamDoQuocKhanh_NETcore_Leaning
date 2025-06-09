using Microsoft.AspNetCore.Mvc;
using PdqkLesson8.Models;
using System.Diagnostics;

namespace PdqkLesson8.Controllers
{
    public class QKHomeController : Controller
    {
        private readonly ILogger<QKHomeController> _logger;

        public QKHomeController(ILogger<QKHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult PdqkIndex()
        {
            return View();
        }

        public IActionResult PdqkPrivacy()
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
