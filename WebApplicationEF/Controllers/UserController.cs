using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEF.Controllers
{
    public class UserController : ControllerBase
    {
        #region Propertirs
        IUserService _UserService;
        #endregion

        #region Constructors
        public UserController(IUserService sqlUserService)
        {
            _UserService = sqlUserService;
        }
        #endregion

        #region APIs
        [Route("User")]
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return _UserService.GetAll();
        }

        [Route("User/{Id}")]
        [HttpGet]
        public Task<User> Get(int Id)
        {
            return _UserService.GetById(Id);
        }

        [Route("User")]
        [HttpPost]
        public void Post([FromBody]User user)
        {
            _UserService.Add(user);
        }

        [Route("User/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _UserService.Delete(id);
        }

        #endregion
    }
}
