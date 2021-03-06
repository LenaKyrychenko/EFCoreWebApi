﻿using BLL.DTO;
using ClassLibrary1.Entities;
using DAL;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces.IServices
{
    public interface ITourService
    {
        IEnumerable<TourDTO> GetAll(PagingParameters pagingParameters);
        IEnumerable<TourDTO> GetFilter(PagingParameters pagingParameters);
        Task<Tour> GetById(int id);
        void Add(Tour obj);
        void Update(Tour obj);
        void Delete(int id);
    }
}
