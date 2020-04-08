using ClassLibrary1.Entities;
using ClassLibrary1.Repositories;
using ClassLibrary2;
using DAL.Interfaces.IRepositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DAL.Repositories
{
    public class TourRepository : GenericRepository<Tour>, ITourRepository
    {
        public TourRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
