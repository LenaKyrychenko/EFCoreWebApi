using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Interfaces
{
    public interface IGenericRepository<T> where T:BaseEntity
    {
        IEnumerable<T> GetAll();
        T GetById(int id);
        void Add(T obj);
        void Update(T obj);
        void Delete(int id);
    }
}
