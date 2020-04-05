using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class ReservationService : IReservationService
    {
        IUnitOfWork unitOfWork;
        public ReservationService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(Reservation obj)
        {
            unitOfWork.ReservationRepository.Add(obj);
        }

        public void Delete(int id)
        {
            unitOfWork.ReservationRepository.Delete(id);
        }

        public IEnumerable<Reservation> GetAll()
        {
            return unitOfWork.ReservationRepository.GetAll();
        }

        public Task<Reservation> GetById(int id)
        {
            return unitOfWork.ReservationRepository.GetById(id);
        }

        public void Update(Reservation obj)
        {
            unitOfWork.ReservationRepository.Update(obj);
        }
    }
}
