using Microsoft.AspNetCore.Mvc;
using PocApplication.Entities;
using PocApplication.Models;
using PocApplication.Services.Abstract;

namespace PocApplication.Controllers
{
    public class CourseController : Controller
    {
        private ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }
        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(CourseAddViewModel model)
        {
            if (ModelState.IsValid)
            {
                var course = new Course()
                {
                    Name = model.Name
 
                };
                await _courseService.AddAsync(course);
                return RedirectToAction("Student","Index");
            }
            return View(model);
        }
    }
}
