using ClassLibrary1.Interfaces;
using ClassLibrary1.Interfaces.IServices;
using System;
using System.Collections.Generic;
using System.Text;
using ClassLibrary1.Entities;
using System.Threading.Tasks;
using BLL.DTO;
using BLL;
using System.Security.Claims;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using DAL;
using Microsoft.Extensions.Options;

namespace ClassLibrary1.Services
{
    public class UserService : IUserService
    {
        IUnitOfWork unitOfWork;
        private readonly ApplicationSettings _appSettings;
        public UserService(IUnitOfWork unitOfWork, IOptions<ApplicationSettings> appSettings)
        {
            this.unitOfWork = unitOfWork;
            _appSettings = appSettings.Value;
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
            return new Details(success, message, null);
            
        }

        public void Logout()
        {
            unitOfWork.SignInManager.SignOutAsync();
        }

        public async Task<Details> SignInAsync(UserDTO userDTO)
        {
            string message;
            bool success;
            string token=null;
            User user = await unitOfWork.UserManager.FindByEmailAsync(userDTO.Email);
            if (user != null)
            {
                var result = await unitOfWork.SignInManager.PasswordSignInAsync(user,userDTO.Password, false, false);
                if (result.Succeeded)
                {
                    var tokenDescriptor = new SecurityTokenDescriptor
                    {
                        Subject = new ClaimsIdentity(new Claim[]
                        {
                            new Claim("UserID", user.Id.ToString())
                        }),
                        Expires = DateTime.UtcNow.AddMinutes(15),
                        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_appSettings.JWT_Secret)), SecurityAlgorithms.HmacSha256Signature)
                    };
                    var tokenHandler = new JwtSecurityTokenHandler();
                    var securityToken = tokenHandler.CreateToken(tokenDescriptor);
                    token = tokenHandler.WriteToken(securityToken);

                    message = "Ви успішно авторизовані!";
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
                message = "Error!";
                success = false;
            }

            return new Details(success, message, token);
        }
    }
}
