using BLL.Interfaces.IServices;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class TourService : ITourService
    {
        IUnitOfWork unitOfWork;
        public TourService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(Tour obj)
        {
            unitOfWork.TourRepository.Add(obj);
        }

        public void Delete(int id)
        {
            unitOfWork.TourRepository.Delete(id);
        }

        public IEnumerable<Tour> GetAll(PagingParameters pagingParameters)
        {
            return unitOfWork.TourRepository.GetTours(pagingParameters);
        }

        public Task<Tour> GetById(int id)
        {
            return unitOfWork.TourRepository.GetById(id);
        }

        public void Update(Tour obj)
        {
            unitOfWork.TourRepository.Update(obj);
        }
    }
}
