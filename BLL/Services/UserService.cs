using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Entities;
using System.Threading.Tasks;
using BLL.DTO;
using BLL;

namespace ClassLibrary1.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork unitOfWork;
        public UserService(IUnitOfWork unitOfWork)
        {
            this.unitOfWork = unitOfWork;
        }

        public async Task<Details> CreateAsync(UserDTO userDTO)
        {
            User user = new User()
            {
                UserName = userDTO.Name,
                Surname = userDTO.Surname,
                Email = userDTO.Email
            };

            var check = await unitOfWork.UserManager.FindByEmailAsync(user.Email);
            bool success;
            string message;
            if(check == null)
            {
               var result = await unitOfWork.UserManager.CreateAsync(user, userDTO.Password);
                if (result.Succeeded)
                {
                    message = "Ви успішно зареєстровані! :)";
                    success = true;
                }
                else
                {
                    message = "Помилка!";
                    success = false;
                }
            }
            else
            {
                message = "Такий користувач вже існує!";
                success = false;
            }
            return new Details(success, message);
            
        }


    }
}
