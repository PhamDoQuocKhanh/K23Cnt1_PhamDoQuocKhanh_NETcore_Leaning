using Microsoft.AspNetCore.Mvc;
using PdqkLesson6.Models;

namespace PdqkLesson6.Controllers
{
    public class PdqkEmployeeController : Controller
    {
        // Biến static giữ danh sách học viên
        private static List<PdqkEmployee> pdqkEmployees = new List<PdqkEmployee>()
        {
            new PdqkEmployee()
            {
                PdqkId = 1,
                PdqkName = "Phạm Đỗ Quốc Khánh",
                PdqkBirthDay = new DateTime(2005, 09, 01),
                PdqkEmail = "amumu0109@gmail.com",
                PdqkPhone = "0869339401",
                PdqkSalary = 3500000.0f,
                PdqkStatus = 1
            },
            new PdqkEmployee()
            {
                PdqkId = 2,
                PdqkName = "Nguyễn Văn B",
                PdqkBirthDay = new DateTime(2003, 5, 10),
                PdqkEmail = "nguyenb@example.com",
                PdqkPhone = "0912345678",
                PdqkSalary = 4200000.0f,
                PdqkStatus = 1
            },
            new PdqkEmployee()
            {
                PdqkId = 3,
                PdqkName = "Lê Thị C",
                PdqkBirthDay = new DateTime(2002, 3, 22),
                PdqkEmail = "c.le@example.com",
                PdqkPhone = "0901234567",
                PdqkSalary = 4000000.0f,
                PdqkStatus = 0
            },
            new PdqkEmployee()
            {
                PdqkId = 4,
                PdqkName = "Phạm Văn D",
                PdqkBirthDay = new DateTime(2001, 8, 5),
                PdqkEmail = "d.pham@example.com",
                PdqkPhone = "0987654321",
                PdqkSalary = 4600000.0f,
                PdqkStatus = 1
            },
            new PdqkEmployee()
            {
                PdqkId = 5,
                PdqkName = "Ngô Thị E",
                PdqkBirthDay = new DateTime(2005, 11, 30),
                PdqkEmail = "e.ngo@example.com",
                PdqkPhone = "0938123456",
                PdqkSalary = 3900000.0f,
                PdqkStatus = 1
            }

            // ... các học viên khác
        };
        public IActionResult PdqkIndex()
        {
            return View(pdqkEmployees);
        }

        // Hiển thị form tạo mới học viên
        [HttpGet]
        public IActionResult PdqkCreate()
        {
            return View();
        }

        // Xử lý tạo mới học viên
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PdqkCreate(PdqkEmployee newEmployee)
        {
            if (!ModelState.IsValid)
            {
                return View(newEmployee);
            }

            newEmployee.PdqkId = pdqkEmployees.Any() ? pdqkEmployees.Max(e => e.PdqkId) + 1 : 1;
            pdqkEmployees.Add(newEmployee);

            return RedirectToAction("PdqkIndex");
        }

        // Chi tiết học viên theo id
        public IActionResult GetEmployee(int id)
        {
            var employee = pdqkEmployees.FirstOrDefault(e => e.PdqkId == id);
            if (employee == null)
            {
                return NotFound(); // Nếu không có học viên với id đó
            }
            return View(employee); // Truyền model sang View
        }

    }
}
