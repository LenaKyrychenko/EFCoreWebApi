using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface ITypesOfTourService
    {
        IEnumerable<TypesOfTour> GetAll();
        Task<TypesOfTour> GetById(int id);
        void Add(TypesOfTour obj);
        void Update(TypesOfTour obj);
        void Delete(int id);
    }
}
