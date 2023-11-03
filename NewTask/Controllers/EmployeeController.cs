using Microsoft.AspNetCore.Mvc;
using NewTask.Models;
using System.Collections.Generic;

namespace NewTask.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            Employee employee = new Employee()
            {
                Name = "Nadir",
                Surname="Eliyev",
                Profession="Fehle",
                PhoneNumber=7585463

            };
            Employee employee2 = new Employee()
            {
                Name = "Hesen",
                Surname = "Orucov",
                Profession = "Muhendis",
                PhoneNumber = 5216874
            };
            List<Employee> employees = new List<Employee>();
            employees.Add(employee);
            employees.Add(employee2);
            return View(employees);
        }
    }
}
