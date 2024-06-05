using DamilahExercise.Data;
using DamilahExercise.Models.Entities;
using DamilahExercise.Repository.RepositoryInterfaces;
using Microsoft.EntityFrameworkCore;

namespace DamilahExercise.Repository.RepositoryImplementation
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ApplicationDbContext context;

        public TeacherRepository(ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }

        public List<Teacher> GetAllTeachers()
        {
            return context.Teachers.Include(t => t.Subjects).ToList();
        }

        public Teacher GetTeacherById(int id)
        {
            return context.Teachers.Find(id);
        }

        public void AddTeacher(Teacher teacher)
        {

            context.Teachers.Add(teacher);
            context.SaveChanges();
        }

        public void UpdateTeacher(Teacher teacher)
        {
            context.Teachers.Update(teacher);
            context.SaveChanges();
        }

        public void DeleteTeacher(int id)
        {
            var teacher = context.Teachers.Find(id);
            if (teacher != null)
            {
                context.Teachers.Remove(teacher);
                context.SaveChanges();
            }
        }
    }
}
