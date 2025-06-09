using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PdqkLesson8.Models;

namespace PdqkLesson8.Controllers
{
    public class PdqkAccontController : Controller
    {
        // GET: PdqkAccontController
        public ActionResult PdqkIndex()
        {

            List<PdqkAccount02> accounts = new List<PdqkAccount02>();
           
            return View(accounts);
        
        }

        // GET: PdqkAccontController/Details/5
        public ActionResult PdqkDetails(int id)
        {
            return View();
        }

        // GET: PdqkAccontController/Create
        public ActionResult PdqkCreate()
        {
            var accounts = new List<PdqkAccount02>
            {
                new PdqkAccount02
                {
                    Id = 1,
                    FullName = "Nguyễn Văn A",
                    Email = "vana@example.com",
                    Phone = "0912345678",
                    Address = "123 Đường A",
                    Avatar = "avatar1.jpg",
                    Birthday = new DateTime(1990, 1, 1),
                    Gender = "Nam",
                    Password = "123456",
                    Facebook = "https://facebook.com/vana"
                },
                new PdqkAccount02
                {
                    Id = 2,
                    FullName = "Trần Thị B",
                    Email = "thib@example.com",
                    Phone = "0987654321",
                    Address = "456 Đường B",
                    Avatar = "avatar2.jpg",
                    Birthday = new DateTime(1995, 5, 5),
                    Gender = "Nữ",
                    Password = "abcdef",
                    Facebook = "https://facebook.com/thib"
                }
            };

            return View(accounts); // ✅ truyền danh sách
        }

        // POST: PdqkAccontController/Create
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

        // GET: PdqkAccontController/Edit/5
        public ActionResult PdqkEdit(int id)
        {
            return View();
        }

        // POST: PdqkAccontController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PdqkEdit(int id, IFormCollection collection)
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

        // GET: PdqkAccontController/Delete/5
        public ActionResult PdqkDelete(int id)
        {
            return View();
        }

        // POST: PdqkAccontController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult PdqkDelete(int id, IFormCollection collection)
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
