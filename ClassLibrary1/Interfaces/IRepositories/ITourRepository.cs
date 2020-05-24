using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Interfaces.IRepositories
{
    public interface ITourRepository : IGenericRepository<Tour>
    {
        IEnumerable<Tour> GetTours(PagingParameters pagingParameters);
        IEnumerable<Tour> GetFilter(PagingParameters pagingParameters);
    }
}
