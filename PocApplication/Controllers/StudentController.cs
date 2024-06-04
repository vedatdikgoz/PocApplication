using Microsoft.AspNetCore.Mvc;
using PocApplication.Entities;
using PocApplication.Models;
using PocApplication.Services.Abstract;

namespace PocApplication.Controllers
{
    public class StudentController : Controller
    {
        private IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
  
        public async Task<IActionResult> Index()
        {
            var studenttListViewModel = new StudentListViewModel()
            {
                Students = await _studentService.GetAllStudentsWithExamResultsAsync()
            };
            return View(studenttListViewModel);
        }

     
        public IActionResult Create()
        {
            return View();
        }

     
       [HttpPost]
       [ValidateAntiForgeryToken]
        public  async Task<IActionResult> Create(StudentAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                var student = new Student()
                {
                    FullName = model.FullName,
                    Number = model.Number,
                    Email = model.Email,
                    GsmNumber = model.GsmNumber,
                };
                await _studentService.AddAsync(student);
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
