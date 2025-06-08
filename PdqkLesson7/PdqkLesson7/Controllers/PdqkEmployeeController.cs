using Microsoft.AspNetCore.Mvc;
using PdqkLesson7.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace PdqkLesson7.Controllers
{
    public class PdqkEmployeeController : Controller
    {
        // Biến static giữ danh sách nhân viên
        private static List<PdqkEmployee> PdqkListEmployees = new List<PdqkEmployee>()
        {
            new PdqkEmployee() { PdqkId = 1, PdqkName = "Phạm Đỗ Quốc Khánh", PdqkBirthDay = new DateTime(2005, 09, 01), PdqkEmail = "amumu0109@gmail.com", PdqkPhone = "0869339401", PdqkSalary = 3500000.0f, PdqkStatus = 1 },
            new PdqkEmployee() { PdqkId = 2, PdqkName = "Nguyễn Văn B", PdqkBirthDay = new DateTime(2003, 5, 10), PdqkEmail = "nguyenb@example.com", PdqkPhone = "0912345678", PdqkSalary = 4200000.0f, PdqkStatus = 1 },
            new PdqkEmployee() { PdqkId = 3, PdqkName = "Lê Thị C", PdqkBirthDay = new DateTime(2002, 3, 22), PdqkEmail = "c.le@example.com", PdqkPhone = "0901234567", PdqkSalary = 4000000.0f, PdqkStatus = 0 },
            new PdqkEmployee() { PdqkId = 4, PdqkName = "Phạm Văn D", PdqkBirthDay = new DateTime(2001, 8, 5), PdqkEmail = "d.pham@example.com", PdqkPhone = "0987654321", PdqkSalary = 4600000.0f, PdqkStatus = 1 },
            new PdqkEmployee() { PdqkId = 5, PdqkName = "Ngô Thị E", PdqkBirthDay = new DateTime(2005, 11, 30), PdqkEmail = "e.ngo@example.com", PdqkPhone = "0938123456", PdqkSalary = 3900000.0f, PdqkStatus = 1 }
        };

        // Hiển thị danh sách nhân viên
        public IActionResult PdqkIndex()
        {
            return View(PdqkListEmployees);
        }

        // GET: Hiển thị form tạo mới
        public IActionResult PdqkCreate()
        {
            var model = new PdqkEmployee();
            return View(model);
        }

        // POST: Thêm mới nhân viên
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PdqkCreate(PdqkEmployee model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    PdqkListEmployees.Add(model);
                    return RedirectToAction(nameof(PdqkIndex));
                }
                return View(model);
            }
            catch (Exception)
            {
                ModelState.AddModelError("", "Có lỗi xảy ra khi tạo mới nhân viên.");
                return View(model);
            }
        }

        // GET: Hiển thị form chỉnh sửa
        public IActionResult PdqkEdit(int id)
        {
            var employee = PdqkListEmployees.FirstOrDefault(e => e.PdqkId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Cập nhật thông tin nhân viên
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PdqkEdit(int id, PdqkEmployee model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var existing = PdqkListEmployees.FirstOrDefault(e => e.PdqkId == id);
                    if (existing == null)
                    {
                        return NotFound();
                    }

                    existing.PdqkName = model.PdqkName;
                    existing.PdqkBirthDay = model.PdqkBirthDay;
                    existing.PdqkEmail = model.PdqkEmail;
                    existing.PdqkPhone = model.PdqkPhone;
                    existing.PdqkSalary = model.PdqkSalary;
                    existing.PdqkStatus = model.PdqkStatus;

                    return RedirectToAction(nameof(PdqkIndex));
                }

                return View(model);
            }
            catch
            {
                ModelState.AddModelError("", "Có lỗi xảy ra khi cập nhật.");
                return View(model);
            }
        }

        // Xem chi tiết nhân viên
        public IActionResult PdqkDetails(int id)
        {
            var employee = PdqkListEmployees.FirstOrDefault(e => e.PdqkId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // GET: Hiển thị xác nhận xóa
        public IActionResult PdqkDelete(int id)
        {
            var employee = PdqkListEmployees.FirstOrDefault(e => e.PdqkId == id);
            if (employee == null)
            {
                return NotFound();
            }
            return View(employee);
        }

        // POST: Xóa nhân viên
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult PdqkDelete(int id, IFormCollection collection)
        {
            try
            {
                var employee = PdqkListEmployees.FirstOrDefault(e => e.PdqkId == id);
                if (employee != null)
                {
                    PdqkListEmployees.Remove(employee);
                }
                return RedirectToAction(nameof(PdqkIndex));
            }
            catch
            {
                return View();
            }
        }
    }
}
