using GymApp.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GymApp.Controllers
{
    
    public class EmployeeController : Controller
    {
        private readonly Context _context;
        public EmployeeController(Context context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            var values = _context.employees.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult NewEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewEmployee(Employee e)
        {
            _context.employees.Add(e);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult DeleteEmployee(int ID)
        {
            var emp = _context.employees.Find(ID);
            _context.employees.Remove(emp);
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
        public IActionResult GetEmployee(int ID)
        {
            var emp=_context.employees.Find(ID);    
            return View("GetEmployee",emp);
        }
        public IActionResult UpdateEmployee(Employee e)
        {
            var emp = _context.employees.Find(e.ID);
            emp.Name=e.Name;
            emp.Surname=e.Surname;
            emp.Position=e.Position;
            _context.SaveChanges();
            return RedirectToAction("Index");

        }
    }
}
