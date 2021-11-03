using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProjectCore.Models;

namespace ProjectCore.Controllers
{
    public class DepartmentController : Controller
    {
        Context context = new Context();

        public IActionResult Index()
        {
            var values = context.Departments.ToList();
            return View(values);
        }

        // Departman Ekleme
        [HttpGet] // İlk açılan sayfamız (HttpGet)
        public IActionResult NewDepartment()
        {
            return View();
        }

        [HttpPost] // Ekleme yapılan kısım (HttpPost)
        public IActionResult NewDepartment(Department dep)
        {
            context.Departments.Add(dep);

            context.SaveChanges(); // değişiklikleri kaydet
            return RedirectToAction("Index"); // ekleme işlemimiz bittikten sonra beni doğrudan ".../Departman/Index" bağlantısına gönderiyor.
        }

        // Departman Silme
        public IActionResult DeleteDepartment(int Id)
        {
            var dep = context.Departments.Find(Id); // Context Departmans'da ki Id yi bul
            context.Departments.Remove(dep); // dep değerinin olduğu Departmanı sil

            context.SaveChanges(); // değişiklikleri kaydet
            return RedirectToAction("Index"); // ekleme işlemimiz bittikten sonra beni doğrudan ".../Departman/Index" bağlantısına gönderiyor.
        }

        // Departman Güncelleme fonksiyonları (Önce Show ile gösteriyor daha sonra Update ile göncelliyor)
        public IActionResult ShowDepartment(int Id)
        {
            var dep = context.Departments.Find(Id);
            return View("ShowDepartment", dep);
        }

        public IActionResult UpdateDepartment(Department department)
        {
            var dep = context.Departments.Find(department.DepartmentId);
            dep.DepartmentName = department.DepartmentName;

            context.SaveChanges();
            return RedirectToAction("Index");
        }

        // Department Detayları
        public IActionResult DepartmentDetails(int Id)
        {
            var values = context.Employees.Where(x => x.DepartmentId == Id).ToList();

            var departmentName = context.Departments.Where(x => x.DepartmentId == Id).Select(y => y.DepartmentName).FirstOrDefault();
            ViewBag.depName = departmentName;
            return View(values);
        }
    }
}
