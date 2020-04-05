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
        public UnitOfWork(IReservationRepository reservationRepository,
            IUserRepository userRepository)
        {
            this.reservationRepository = reservationRepository;
            this.userRepository = userRepository;
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
    }
}
