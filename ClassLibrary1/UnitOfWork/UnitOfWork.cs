using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IRepositories;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IReservationRepository reservationRepository;
        private readonly ITypesOfTourRepository typesOfTourRepository;
        private readonly ITypesOfTransportRepository typesOfTransportRepository;
        private readonly ITourRepository tourRepository;
        public UnitOfWork(IReservationRepository reservationRepository,
            ITypesOfTourRepository typesOfTourRepository,
            ITypesOfTransportRepository typesOfTransportRepository,
            ITourRepository tourRepository)
        {
            this.reservationRepository = reservationRepository;
            this.typesOfTourRepository = typesOfTourRepository;
            this.typesOfTransportRepository = typesOfTransportRepository;
            this.tourRepository = tourRepository;
        }
        public IReservationRepository ReservationRepository
        {
            get
            {
                return reservationRepository;
            }
        }

        public ITypesOfTourRepository TypesOfTourRepository
        {
            get
            {
                return typesOfTourRepository;
            }
        }

        public ITypesOfTransportRepository TypesOfTransportRepository
        {
            get
            {
                return typesOfTransportRepository;
            }
        }

        public ITourRepository TourRepository
        {
            get
            {
                return tourRepository;
            }
        }
    }
}
