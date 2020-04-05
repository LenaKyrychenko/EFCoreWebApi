using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface ITypesOfTransportService
    {
        IEnumerable<TypesOfTransport> GetAll();
        Task<TypesOfTransport> GetById(int id);
        void Add(TypesOfTransport obj);
        void Update(TypesOfTransport obj);
        void Delete(int id);
    }
}
