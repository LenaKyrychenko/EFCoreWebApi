using BLL;
using BLL.DTO;
using ClassLibrary1.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1.Interfaces.IServices
{
    public interface IUserService
    {
        public Task<Details> CreateAsync(UserDTO userDTO);
    }
}
