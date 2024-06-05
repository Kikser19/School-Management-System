using DamilahExercise.Service.ServiceImplementation;
using DamilahExercise.Service.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace DamilahExercise.Controllers
{
    [Route("/teacher")]
    [ApiController]
    public class TeacherController : Controller
    {
        private readonly ITeacherService _teacherService;

        public TeacherController(ITeacherService teacherService)
        {
            _teacherService = teacherService;
        }
        public IActionResult ListTeachers()
        {
            var teachers = _teacherService.GetAllTeachers();
            return View(teachers);
        }
    }
}
