﻿using AutoMapper;
using BLL.DTO;
using BLL.Interfaces.IServices;
using ClassLibrary1.Entities;
using DAL;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEF.Controllers
{
    public class TourController : ControllerBase
    {
        #region Propertirs
        ITourService _TourService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public TourController(ITourService sqlTourService, IMapper mapper)
        {
            _TourService = sqlTourService;
            _mapper = mapper;
        }
        #endregion

        #region APIs
        [Route("Tour")]
        [HttpGet]
        public IActionResult Get([FromQuery] PagingParameters pagingParameters)
        {
            var models = _TourService.GetAll(pagingParameters).ToList();

            var list = _mapper.Map<List<Tour>, List<TourDTO>>(models);

            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
        }

        [Route("Tour/{Id}")]
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var models = _TourService.GetById(Id);
            Tour tour = models.Result;

            var list = _mapper.Map<Tour, TourDTO>(tour);

            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
        }

        [Route("Tour")]
        [HttpPost]
        public void Post([FromBody]Tour tour)
        {
            _TourService.Add(tour);
        }

        [Route("Tour/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _TourService.Delete(id);
        }

        #endregion
    }
}
