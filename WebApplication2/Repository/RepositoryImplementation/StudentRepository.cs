using DamilahExercise.Data;
using DamilahExercise.Models.Entities;
using DamilahExercise.Repository.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace DamilahExercise.Repository.RepositoryImplementation
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ApplicationDbContext context;

        public StudentRepository(ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }

        public List<Student> GetAllStudents()
        {
            return context.Students.Include(s => s.Subjects).ToList();
        }

        public Student GetStudentById(int id)
        {
            return context.Students.Find(id);
        }

        public void AddStudent(Student student)
        {

            context.Students.Add(student);
            context.SaveChanges();
        }

        public void UpdateStudent(Student student)
        {
            context.Students.Update(student);
            context.SaveChanges();
        }

        public void DeleteStudent(int id)
        {
            var student = context.Students.Find(id);
            if (student != null)
            {
                context.Students.Remove(student);
                context.SaveChanges();
            }
        }
    }
}
