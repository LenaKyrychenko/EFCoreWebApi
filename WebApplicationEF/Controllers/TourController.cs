using AutoMapper;
using BLL.DTO;
using BLL.Interfaces.IServices;
using ClassLibrary1.Entities;
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
        public IEnumerable<TourDTO> Get()
        {
            var models = _TourService.GetAll().ToList();

            return _mapper.Map<List<Tour>, List<TourDTO>>(models);
        }

        [Route("Tour/{Id}")]
        [HttpGet]
        public TourDTO Get(int Id)
        {
            var models = _TourService.GetById(Id);
            Tour tour = models.Result;

            return _mapper.Map<Tour, TourDTO>(tour);
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
