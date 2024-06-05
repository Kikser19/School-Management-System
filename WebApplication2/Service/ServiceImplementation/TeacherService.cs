using DamilahExercise.Models.Entities;
using DamilahExercise.Repository.RepositoryImplementation;
using DamilahExercise.Repository.RepositoryInterfaces;
using DamilahExercise.Service.ServiceInterfaces;

namespace DamilahExercise.Service.ServiceImplementation
{
    public class TeacherService : ITeacherService
    {
        private readonly ITeacherRepository _repository;
        public TeacherService(ITeacherRepository teacherRepository)
        {
            _repository = teacherRepository;
        }

        public List<Teacher> GetAllTeachers()
        {
            return _repository.GetAllTeachers();
        }

        public Teacher GetTeacherById(int id)
        {
            return _repository.GetTeacherById(id);
        }

        public void AddTeacher(Teacher teacher)
        {

            _repository.AddTeacher(teacher);
        }

        public void UpdateTeacher(Teacher teacher)
        {
            _repository.UpdateTeacher(teacher);
        }

        public void DeleteTeacher(int id)
        {
            _repository.DeleteTeacher(id);
        }
    }
}
