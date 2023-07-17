using GymApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;


namespace GymApp.Controllers
{
    public class LoginController : Controller
    {

        private readonly Context _context;

        public LoginController(Context context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Manager model)
        {
            var manager = _context.managers.FirstOrDefault(u => u.UserName == model.UserName);
            if (manager != null && manager.Password == model.Password)
            {
                
                return View("Login");
            }
            else if (manager == null)
            {
                ModelState.AddModelError("", "Invalid username or password.");
            }
            else
            {
                ModelState.AddModelError("", "Invalid password.");
            }

            return View(model);

          
        }


    }
}
