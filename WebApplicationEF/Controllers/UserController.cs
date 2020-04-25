using AutoMapper;
using BLL.DTO;
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
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public UserController(IUserService sqlUserService, IMapper mapper)
        {
            _UserService = sqlUserService;
            _mapper = mapper;
        }
        #endregion

        #region APIs
        [Route("User")]
        [HttpGet]
        public IActionResult Get()
        {
            var models = _UserService.GetAll().ToList();
            /*var config = new MapperConfiguration(mc => mc.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);*/

            var list = _mapper.Map<List<User>, List<UserDTO>>(models);

            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
        }

        [Route("User/{Id}")]
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var models = _UserService.GetById(Id);
            User user = models.Result;

            var list = _mapper.Map<User, UserDTO>(user);

            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
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
