using Microsoft.EntityFrameworkCore;
using DamilahExercise.Data;
using DamilahExercise.Models.Entities;
using DamilahExercise.Repository.RepositoryInterfaces;

namespace DamilahExercise.Repository.RepositoryImplementation
{
    public class SubjectRepository : ISubjectRepository
    {
        private readonly ApplicationDbContext context;

        public SubjectRepository(ApplicationDbContext dbcontext)
        {
            context = dbcontext;
        }

        public List<Subject> GetAllSubjects()
        {
            return context.Subjects.Include(s => s.Teacher).ToList();
        }

        public Subject GetSubjectById(int id)
        {
            return context.Subjects.Include(s => s.Teacher)
                        .FirstOrDefault(s => s.Id == id);
        }

        public void AddSubject(Subject subject)
        {
            
            context.Subjects.Add(subject);
            context.SaveChanges();
        }

        public void UpdateSubject(Subject subject)
        {
            context.Subjects.Update(subject);
            context.SaveChanges();
        }

        public void DeleteSubject(int id)
        {
            var subject =   context.Subjects.Find(id);
            if (subject != null)
            {
                context.Subjects.Remove(subject);
                context.SaveChanges();
            }
        }
    }
}
