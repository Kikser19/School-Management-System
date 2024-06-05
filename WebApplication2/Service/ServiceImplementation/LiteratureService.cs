using DamilahExercise.Models.Entities;
using DamilahExercise.Repository.RepositoryImplementation;
using DamilahExercise.Repository.RepositoryInterfaces;
using DamilahExercise.Service.ServiceInterfaces;

namespace DamilahExercise.Service.ServiceImplementation
{
    public class LiteratureService : ILiteratureService
    {
        private readonly ILiteratureRepository _repository;
        public LiteratureService(ILiteratureRepository literatureRepository)
        {
            _repository = literatureRepository;
        }
        public List<Literature> GetAllLiteratures()
        {
            return _repository.GetAllLiteratures();
        }

        public Literature GetLiteratureById(int id)
        {
            return _repository.GetLiteratureById(id);
        }

        public void AddLiterature(Literature literature)
        {
            _repository.AddLiterature(literature);
        }

        public void UpdateLiterature(Literature literature)
        {
            _repository.UpdateLiterature(literature);
        }

        public void DeleteLiterature(int id)
        {
            _repository.DeleteLiterature(id);
        }
        public List<Literature> GetLiteraturesBySubjectId(int subjectId)
        {
            return _repository.GetLiteraturesBySubjectId(subjectId);
        }
    }
}
