﻿using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface IReservationService
    {
        IEnumerable<Reservation> GetAll();
        Task<Reservation> GetById(int id);
        void Add(Reservation obj);
        void Update(Reservation obj);
        void Delete(int id);
    }
}
