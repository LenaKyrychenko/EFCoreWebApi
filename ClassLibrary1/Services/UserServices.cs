using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Entities;
using System.Threading.Tasks;

namespace ClassLibrary1.Services
{
    public class UserServices : IUserService
    {
        IUnitOfWork unitOfWork;
        public UserServices(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public void Add(User obj)
        {
            unitOfWork.UserRepository.Add(obj);
        }

        public void Delete(int id)
        {
            unitOfWork.UserRepository.Delete(id);
        }

        public IEnumerable<User> GetAll()
        {
            return unitOfWork.UserRepository.GetAll();
        }

        public Task<User> GetById(int id)
        {
            return unitOfWork.UserRepository.GetById(id);
        }

        public void Update(User obj)
        {
            unitOfWork.UserRepository.Update(obj);
        }
    }
}
