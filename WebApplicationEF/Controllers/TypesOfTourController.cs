﻿using AutoMapper;
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
        public IEnumerable<TypesOfTourDTO> Get()
        {
            var models = _TypesOfTourService.GetAll().ToList();

            return _mapper.Map<List<TypesOfTour>, List<TypesOfTourDTO>>(models);
        }

        [Route("TypesOfTour/{Id}")]
        [HttpGet]
        public TypesOfTourDTO Get(int Id)
        {
            var models = _TypesOfTourService.GetById(Id);
            TypesOfTour typesOfTour = models.Result;

            return _mapper.Map<TypesOfTour, TypesOfTourDTO>(typesOfTour);
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
