using DamilahExercise.Service.ServiceImplementation;
using DamilahExercise.Service.ServiceInterfaces;
using Microsoft.AspNetCore.Mvc;

namespace DamilahExercise.Controllers
{
    [Route("/students")]
    [ApiController]
    public class StudentController : Controller
    {
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public IActionResult ListStudents()
        {
            var students = _studentService.GetAllStudents();
            return View(students);
        }
    }
}
