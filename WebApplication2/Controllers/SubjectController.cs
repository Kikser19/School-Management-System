using Microsoft.AspNetCore.Mvc;
using DamilahExercise.Models.Entities;
using DamilahExercise.Models.ViewModels;
using DamilahExercise.Repository.RepositoryInterfaces;
using DamilahExercise.Service.ServiceImplementation;
using DamilahExercise.Service.ServiceInterfaces;

namespace DamilahExercise.Controllers
{
    [Route("/")]
    [ApiController]
    public class SubjectsController : Controller
    {
        private readonly ISubjectService _subjectService;
        private readonly ILiteratureService _literatureService;
        private readonly ITeacherService _teacherService;

        public SubjectsController(ISubjectService subjectService, ILiteratureService literatureService, ITeacherService teacherService)
        {
            _subjectService = subjectService;
            _literatureService = literatureService;
            _teacherService = teacherService;
        }
        [HttpGet]
        public IActionResult ListSubjects()
        {
            var subjects = _subjectService.GetAllSubjects();
            return View(subjects);
        }
        [HttpGet("details/{id}")]
        public IActionResult Details(int id)
        {
            var subject = _subjectService.GetSubjectById(id);
            var literatures = _literatureService.GetLiteraturesBySubjectId(id);
            if (subject == null)
            {
                return NotFound();
            }
            var viewModel = new SubjectDetailsViewModel
            {
                Subject = subject,
                Literatures = literatures
            };

            return View(viewModel);
        }

    }
}
