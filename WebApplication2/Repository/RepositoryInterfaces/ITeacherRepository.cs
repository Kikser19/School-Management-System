using DamilahExercise.Models.Entities;

namespace DamilahExercise.Repository.RepositoryInterfaces
{
    public interface ITeacherRepository
    {
       
            List<Teacher> GetAllTeachers();
            Teacher GetTeacherById(int id);
            void AddTeacher(Teacher teacher);
            void UpdateTeacher(Teacher teacher);
            void DeleteTeacher(int id);
        
    }
}
