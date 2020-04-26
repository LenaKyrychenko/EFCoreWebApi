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
    public class TypesOfTourController : ControllerBase
    {
        #region Propertirs
        ITypesOfTourService _TypesOfTourService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public TypesOfTourController(ITypesOfTourService sqlTypesOfTourService, IMapper mapper)
        {
            _TypesOfTourService = sqlTypesOfTourService;
            _mapper = mapper;
        }
        #endregion

        #region APIs
        [Route("TypesOfTour")]
        [HttpGet]
        public IActionResult Get()
        {
            var models = _TypesOfTourService.GetAll().ToList();

            var list = _mapper.Map<List<TypesOfTour>, List<TypesOfTourDTO>>(models);

            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
        }

        [Route("TypesOfTour/{Id}")]
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var models = _TypesOfTourService.GetById(Id);
            TypesOfTour typesOfTour = models.Result;

            var list = _mapper.Map<TypesOfTour, TypesOfTourDTO>(typesOfTour);

            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
        }

        [Route("TypesOfTour")]
        [HttpPost]
        public void Post([FromBody]TypesOfTour typesOfTour)
        {
            _TypesOfTourService.Add(typesOfTour);
        }

        [Route("TypesOfTour/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _TypesOfTourService.Delete(id);
        }

        #endregion
    }
}
