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
        public UnitOfWork(IReservationRepository reservationRepository)
        {
            this.reservationRepository = reservationRepository;
        }
        public IReservationRepository ReservationRepository
        {
            get
            {
                return reservationRepository;
            }
        }
    }
}
