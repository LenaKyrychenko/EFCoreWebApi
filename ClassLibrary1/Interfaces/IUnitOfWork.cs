using ClassLibrary1.Interfaces.IRepositories;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Interfaces
{
    public interface IUnitOfWork
    {
        IReservationRepository ReservationRepository { get; }
        ITypesOfTourRepository TypesOfTourRepository { get; }
        ITypesOfTransportRepository TypesOfTransportRepository { get; }
        ITourRepository TourRepository { get; }
    }
}
