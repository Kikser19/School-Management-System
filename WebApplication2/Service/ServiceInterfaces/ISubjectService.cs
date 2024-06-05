using DamilahExercise.Models.Entities;

namespace DamilahExercise.Service.ServiceInterfaces
{
    public interface ISubjectService
    {
        List<Subject> GetAllSubjects();

        Subject GetSubjectById(int id);

        void AddSubject(Subject subject);

        void UpdateSubject(Subject subject);

        void DeleteSubject(int id);
    }
}
