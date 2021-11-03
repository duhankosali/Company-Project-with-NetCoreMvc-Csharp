using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization; // kimlik doğrulama
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProjectCore.Models;

namespace ProjectCore.Controllers
{
    public class EmployeeController : Controller
    {
        Context context = new Context();

        [Authorize] // Startup 'da Autherize ile ilgili kodlar mevcut.
        public IActionResult Index()
        {
            var values = context.Employees.Include(x => x.Department).ToList();
            return View(values);
        }

        [HttpGet]
        public IActionResult NewEmployee()
        {
            //DropdownList kullanımı (ComboBox)
            List<SelectListItem> values = (from x in context.Departments.ToList()
                                           select new SelectListItem
                                           {
                                               Text = x.DepartmentName,
                                               Value = x.DepartmentId.ToString()
                                           }).ToList();
            ViewBag.value = values; // values'i value isimli değişkene atadım. (ViewBag kullanarak)
            return View();
        }
        [HttpPost]
        public IActionResult NewEmployee(Employee employee)
        {
            var emp = context.Departments.Where(x => x.DepartmentId == employee.Department.DepartmentId).FirstOrDefault();
            employee.Department = emp;
            context.Employees.Add(employee);

            context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        
    }
}
