using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces.IRepositories;
using ClassLibrary2;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Repositories
{
    public class UserRepository : GenericRepository<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
