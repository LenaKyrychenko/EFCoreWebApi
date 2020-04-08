using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Interfaces.IServices
{
    public interface ITourService
    {
        IEnumerable<Tour> GetAll();
        Task<Tour> GetById(int id);
        void Add(Tour obj);
        void Update(Tour obj);
        void Delete(int id);
    }
}
