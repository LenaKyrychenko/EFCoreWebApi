using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IReservationRepository reservationRepository;
        private readonly IUserRepository userRepository;
        private readonly ITypesOfTourRepository typesOfTourRepository;
        private readonly ITypesOfTransportRepository typesOfTransportRepository;
        public UnitOfWork(IReservationRepository reservationRepository,
            IUserRepository userRepository,
            ITypesOfTourRepository typesOfTourRepository,
            ITypesOfTransportRepository typesOfTransportRepository)
        {
            this.reservationRepository = reservationRepository;
            this.userRepository = userRepository;
            this.typesOfTourRepository = typesOfTourRepository;
            this.typesOfTransportRepository = typesOfTransportRepository;
        }
        public IReservationRepository ReservationRepository
        {
            get
            {
                return reservationRepository;
            }
        }

        public IUserRepository UserRepository
        {
            get
            {
                return userRepository;
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
    }
}
