using DamilahExercise.Data;
using DamilahExercise.Models.Entities;
using DamilahExercise.Repository.RepositoryImplementation;
using DamilahExercise.Repository.RepositoryInterfaces;
using DamilahExercise.Service.ServiceInterfaces;

namespace DamilahExercise.Service.ServiceImplementation
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public List<Student> GetAllStudents()
        {
            return _studentRepository.GetAllStudents();
        }

        public Student GetStudentById(int id)
        {
            return _studentRepository.GetStudentById(id);
        }

        public void AddStudent(Student student)
        {
            _studentRepository.AddStudent(student); 
        }

        public void UpdateStudent(Student student)
        {
            _studentRepository.UpdateStudent(student);
        }

        public void DeleteStudent(int id)
        {
            _studentRepository.DeleteStudent(id);
        }
    }
}
