using Microsoft.AspNetCore.Mvc;

namespace PdqkLesson7.Controllers
{
    public class PdqkMemBerController : Controller
    {
        // GET: PdqkMemBerController
        public ActionResult Index()
        {
            return View();
        }

        // GET: PdqkMemBerController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: PdqkMemBerController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: PdqkMemBerController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PdqkMemBerController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: PdqkMemBerController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: PdqkMemBerController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: PdqkMemBerController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}