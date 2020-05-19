using AutoMapper;
using BLL.DTO;
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
        IMapper mapper;
        public TourService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            this.unitOfWork = unitOfWork;
            this.mapper = mapper;
        }

        public void Add(Tour obj)
        {
            unitOfWork.TourRepository.Add(obj);
        }

        public void Delete(int id)
        {
            unitOfWork.TourRepository.Delete(id);
        }

        public IEnumerable<TourDTO> GetAll(PagingParameters pagingParameters)
        {
            var models = unitOfWork.TourRepository.GetTours(pagingParameters);
            var list = mapper.Map<IEnumerable<Tour>, IEnumerable<TourDTO>>(models);
            return list;
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
