using Microsoft.AspNetCore.Mvc;
using GymApp.Models;
using System.Linq;


namespace GymApp.Controllers
{
    
    public class MemberController : Controller
    {
        private readonly Context _context;
        public MemberController(Context context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var values = _context.members.ToList();
            return View(values);
        }
        [HttpGet]
        public IActionResult NewMember()
        {
            return View();
        }
        [HttpPost]
        public IActionResult NewMember(Member m)
        {
            _context.members.Add(m);
            _context.SaveChanges();
            return RedirectToAction("Index");
              
        }
        public IActionResult DeleteMember(int ID)
        {
            var mem = _context.members.Find(ID);
            _context.members.Remove(mem);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public IActionResult GetMember(int ID)
        {
            var mem=_context.members.Find(ID);
            return View("GetMember",mem);
        }
        public IActionResult UpdateMember(Member m)
        {
            var mem=_context.members.Find(m.ID);
            mem.Name=m.Name;
            mem.Surname = m.Surname;
            mem.Status = m.Status;
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
