using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces.IRepositories;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Repositories
{
    public class TypesOfTransportRepository : GenericRepository<TypesOfTransport>, ITypesOfTransportRepository
    {
        public TypesOfTransportRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
