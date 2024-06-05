using DamilahExercise.Models.Entities;

namespace DamilahExercise.Repository.RepositoryInterfaces
{
    public interface ISubjectRepository
    {
        List<Subject> GetAllSubjects();
        Subject GetSubjectById(int id);
        void AddSubject(Subject subject);
        void UpdateSubject(Subject subject);
        void DeleteSubject(int id);
    }
}
