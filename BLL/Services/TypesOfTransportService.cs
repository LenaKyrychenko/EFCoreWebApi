using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class TypesOfTransportService : ITypesOfTransportService
    {
        IUnitOfWork unitOfWork;
        public TypesOfTransportService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(TypesOfTransport obj)
        {
            unitOfWork.TypesOfTransportRepository.Add(obj);
        }

        public void Delete(int id)
        {
            unitOfWork.TypesOfTransportRepository.Delete(id);
        }

        public IEnumerable<TypesOfTransport> GetAll()
        {
            return unitOfWork.TypesOfTransportRepository.GetAll();
        }

        public Task<TypesOfTransport> GetById(int id)
        {
            return unitOfWork.TypesOfTransportRepository.GetById(id);
        }

        public void Update(TypesOfTransport obj)
        {
            unitOfWork.TypesOfTransportRepository.Update(obj);
        }
    }
}
