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
    public class TypesOfTransportController : ControllerBase
    {
        #region Propertirs
        ITypesOfTransportService _TypesOfTransportService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public TypesOfTransportController(ITypesOfTransportService sqlTypesOfTransportService, IMapper mapper)
        {
            _TypesOfTransportService = sqlTypesOfTransportService;
            _mapper = mapper;
        }
        #endregion

        #region APIs
        [Route("TypesOfTransport")]
        [HttpGet]
        public IEnumerable<TypesOfTransportDTO> Get()
        {
            var models = _TypesOfTransportService.GetAll().ToList();
            /*var config = new MapperConfiguration(mc => mc.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);*/

            return _mapper.Map<List<TypesOfTransport>, List<TypesOfTransportDTO>>(models);
        }

        [Route("TypesOfTransport/{Id}")]
        [HttpGet]
        public TypesOfTransportDTO Get(int Id)
        {
            var models = _TypesOfTransportService.GetById(Id);
            TypesOfTransport typesOfTransport = models.Result;
            /*var config = new MapperConfiguration(mc => mc.CreateMap<User, UserDTO>());
            var mapper = new Mapper(config);*/

            return _mapper.Map<TypesOfTransport, TypesOfTransportDTO>(typesOfTransport);
        }

        [Route("TypesOfTransport")]
        [HttpPost]
        public void Post([FromBody]TypesOfTransport typesOfTransport)
        {
            _TypesOfTransportService.Add(typesOfTransport);
        }

        [Route("TypesOfTransport/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _TypesOfTransportService.Delete(id);
        }

        #endregion
    }
}
