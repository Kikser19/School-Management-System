﻿using DamilahExercise.Models.Entities;

namespace DamilahExercise.Service.ServiceInterfaces
{
    public interface ILiteratureService
    {
        List<Literature> GetAllLiteratures();
        Literature GetLiteratureById(int id);
        void AddLiterature(Literature literature);
        void UpdateLiterature(Literature literature);
        void DeleteLiterature(int id);
        List<Literature> GetLiteraturesBySubjectId(int subjectId);
    }
}
