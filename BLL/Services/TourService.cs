using AutoMapper;
using BLL.DTO;
using BLL.Interfaces.IServices;
using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
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
            var tours = unitOfWork.TourRepository.GetTours(pagingParameters);
            var typestour = unitOfWork.TypesOfTourRepository.GetAll();
            var typestransport = unitOfWork.TypesOfTransportRepository.GetAll();
            var listjoin = from tour in tours
                         join type1 in typestour on tour.TypeOfTourId equals type1.Id
                         join type2 in typestransport on tour.TypeOfTransportId equals type2.Id
                         select new
                         {
                             Tourname = tour.NameTour,
                             Route = tour.Route,
                             TypeOfTour = type1.TypeOfTour,
                             DateOfStart = tour.DateOfStart,
                             DateOfFinish = tour.DateOfFinish,
                             TypeOfTransport = type2.TypeOfTransport,
                             Price = tour.Price
                         };
            List<TourDTO> models = new List<TourDTO>();
            foreach(var l in listjoin)
            {
                TourDTO tourDTO = new TourDTO
                {
                    NameTour = l.Tourname,
                    Route = l.Route,
                    TypeOfTour = l.TypeOfTour,
                    DateOfStart = l.DateOfStart,
                    DateOfFinish = l.DateOfFinish,
                    TypeOfTransport = l.TypeOfTransport,
                    Price = l.Price
                };
                models.Add(tourDTO);
            }
            
            return models;
        }

        public Task<Tour> GetById(int id)
        {
            return unitOfWork.TourRepository.GetById(id);
        }

        public void Update(Tour obj)
        {
            unitOfWork.TourRepository.Update(obj);
        }

        public IEnumerable<TourDTO> GetFilter(PagingParameters pagingParameters)
        {
            if (pagingParameters.TypeOfTour == "All" && pagingParameters.TypeOfTransport == "All")
            {
                var models = unitOfWork.TourRepository.GetFilter(pagingParameters);
                var list = mapper.Map<IEnumerable<Tour>, IEnumerable<TourDTO>>(models);
                return list;
            }
            else if(pagingParameters.TypeOfTour == "All" && pagingParameters.TypeOfTransport != "All")
            {
                var models = unitOfWork.TourRepository.GetFilter(pagingParameters);
                var types1 = unitOfWork.TypesOfTourRepository.GetAll();
                var types2 = unitOfWork.TypesOfTransportRepository.GetAll();
                var list = from tour in models
                           join typetour in types1 on tour.TypeOfTourId equals typetour.Id
                           join typetransport in types2 on tour.TypeOfTransportId equals typetransport.Id
                           where typetransport.TypeOfTransport == pagingParameters.TypeOfTransport
                           select new
                           {
                               Tourname = tour.NameTour,
                               Route = tour.Route,
                               TypeOfTour = typetour.TypeOfTour,
                               DateOfStart = tour.DateOfStart,
                               DateOfFinish = tour.DateOfFinish,
                               TypeOfTransport = typetransport.TypeOfTransport,
                               Price = tour.Price
                           };

                List<TourDTO> tourlist = new List<TourDTO>();
                foreach (var l in list)
                {
                    TourDTO tourDTO = new TourDTO
                    {
                        NameTour = l.Tourname,
                        Route = l.Route,
                        TypeOfTour = l.TypeOfTour,
                        DateOfStart = l.DateOfStart,
                        DateOfFinish = l.DateOfFinish,
                        TypeOfTransport = l.TypeOfTransport,
                        Price = l.Price
                    };
                    tourlist.Add(tourDTO);
                }
                return tourlist;
            }
            else if (pagingParameters.TypeOfTour != "All" && pagingParameters.TypeOfTransport == "All")
            {
                var models = unitOfWork.TourRepository.GetFilter(pagingParameters);
                var types1 = unitOfWork.TypesOfTourRepository.GetAll();
                var types2 = unitOfWork.TypesOfTransportRepository.GetAll();
                var list = from tour in models
                           join typetour in types1 on tour.TypeOfTourId equals typetour.Id
                           join typetransport in types2 on tour.TypeOfTransportId equals typetransport.Id
                           where typetour.TypeOfTour == pagingParameters.TypeOfTour
                           select new
                           {
                               Tourname = tour.NameTour,
                               Route = tour.Route,
                               TypeOfTour = typetour.TypeOfTour,
                               DateOfStart = tour.DateOfStart,
                               DateOfFinish = tour.DateOfFinish,
                               TypeOfTransport = typetransport.TypeOfTransport,
                               Price = tour.Price
                           };

                List<TourDTO> tourlist = new List<TourDTO>();
                foreach (var l in list)
                {
                    TourDTO tourDTO = new TourDTO
                    {
                        NameTour = l.Tourname,
                        Route = l.Route,
                        TypeOfTour = l.TypeOfTour,
                        DateOfStart = l.DateOfStart,
                        DateOfFinish = l.DateOfFinish,
                        TypeOfTransport = l.TypeOfTransport,
                        Price = l.Price
                    };
                    tourlist.Add(tourDTO);
                }
                return tourlist;
            }
            else
            {
                var models = unitOfWork.TourRepository.GetFilter(pagingParameters);
                var types1 = unitOfWork.TypesOfTourRepository.GetAll();
                var types2 = unitOfWork.TypesOfTransportRepository.GetAll();
                var list = from tour in models
                           join typetour in types1 on tour.TypeOfTourId equals typetour.Id
                           join typetransport in types2 on tour.TypeOfTransportId equals typetransport.Id
                           where typetransport.TypeOfTransport == pagingParameters.TypeOfTransport
                           where typetour.TypeOfTour == pagingParameters.TypeOfTour
                           select new
                           {
                               Tourname = tour.NameTour,
                               Route = tour.Route,
                               TypeOfTour = typetour.TypeOfTour,
                               DateOfStart = tour.DateOfStart,
                               DateOfFinish = tour.DateOfFinish,
                               TypeOfTransport = typetransport.TypeOfTransport,
                               Price = tour.Price
                           };

                List<TourDTO> tourlist = new List<TourDTO>();
                foreach (var l in list)
                {
                    TourDTO tourDTO = new TourDTO
                    {
                        NameTour = l.Tourname,
                        Route = l.Route,
                        TypeOfTour = l.TypeOfTour,
                        DateOfStart = l.DateOfStart,
                        DateOfFinish = l.DateOfFinish,
                        TypeOfTransport = l.TypeOfTransport,
                        Price = l.Price
                    };
                    tourlist.Add(tourDTO);
                }
                return tourlist;
            }


        }
    }
}
