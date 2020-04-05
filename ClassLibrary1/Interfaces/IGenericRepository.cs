﻿using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        Task<T> GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}
