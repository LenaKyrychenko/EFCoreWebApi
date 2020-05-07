using ClassLibrary1.Entities;
using ClassLibrary1.Repositories;
using ClassLibrary2;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DAL.Repositories
{
    public class TourRepository : GenericRepository<Tour>, ITourRepository
    {
        public TourRepository(ApplicationContext context) : base(context)
        {

        }

        public IEnumerable<Tour> GetTours(PagingParameters pagingParameters)
        {
            return GetAll()
            .Skip((pagingParameters.PageNumber - 1) * pagingParameters.PageSize)
            .Take(pagingParameters.PageSize)
            .ToList();
        }
    }
}
