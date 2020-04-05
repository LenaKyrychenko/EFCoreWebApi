using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class TypesOfTourService : ITypesOfTourService
    {
        IUnitOfWork unitOfWork;
        public TypesOfTourService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(TypesOfTour obj)
        {
            unitOfWork.TypesOfTourRepository.Add(obj);
        }

        public void Delete(int id)
        {
            unitOfWork.TypesOfTourRepository.Delete(id);
        }

        public IEnumerable<TypesOfTour> GetAll()
        {
            return unitOfWork.TypesOfTourRepository.GetAll();
        }

        public Task<TypesOfTour> GetById(int id)
        {
            return unitOfWork.TypesOfTourRepository.GetById(id);
        }

        public void Update(TypesOfTour obj)
        {
            unitOfWork.TypesOfTourRepository.Update(obj);
        }
    }
}
