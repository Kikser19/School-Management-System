

using System.Collections.Generic;

using DamilahExercise.Models.Entities;
using DamilahExercise.Repository.RepositoryInterfaces;
using DamilahExercise.Service.ServiceInterfaces;

namespace DamilahExercise.Service.ServiceImplementation
{
    public class SubjectService : ISubjectService
    {
        private readonly ISubjectRepository _subjectRepository;
        private readonly ILiteratureRepository _iliteratureRepository;

        public SubjectService(ISubjectRepository subjectRepository, ILiteratureRepository literatureRepository)
        {
            _subjectRepository = subjectRepository;
            _iliteratureRepository = literatureRepository;
        }

        public List<Subject> GetAllSubjects()
        {
            return _subjectRepository.GetAllSubjects();
        }

        public Subject GetSubjectById(int id)
        {
            return _subjectRepository.GetSubjectById(id);
        }

        public void AddSubject(Subject subject)
        {
            _subjectRepository.AddSubject(subject);
        }

        public void UpdateSubject(Subject subject)
        {
            _subjectRepository.UpdateSubject(subject);
        }

        public void DeleteSubject(int id)
        {
            _subjectRepository.DeleteSubject(id);
        }

    }
}


