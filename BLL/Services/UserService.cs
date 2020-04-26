using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Entities;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

       
    }
}
