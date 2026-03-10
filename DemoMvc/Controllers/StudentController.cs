using Microsoft.AspNetCore.Mvc;
using DemoMVC.Data;
using DemoMVC.Models.Entities;
using System.Security.Cryptography.X509Certificates;
namespace DemoMVC.Controllers
{    public class StudentController(ApplicationDbContext context) : Controller
    {
        private readonly ApplicationDbContext _context = context;
        public IActionResult Index()
        {
            // Lấy danh sách sinh viên từ cơ sở dữ liệu
            var listStudents = _context.Students.ToList();
            //truyen danh sách sinh viên vào view
            return View(listStudents);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        +        public IActionResult Create(Student std)
        {    _context.Students.Add(std);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        public async Task<IActionResult> Edit(string id)
        {
            //Tim sinh viên theo mã sinh viên
            var std = await _context.Students.FindAsync(id);
            if (std == null)
            {
                return NotFound();
            }
            return View(std);
        }
        [HttpPost]
        public async Task<IActionResult> Edit(Student std)
        {
            _context.Entry(std).State = EntityState.Modified;
            await _context.SaveChangesAsync();
            return RedirectToAction("Index");
        }
    }
}