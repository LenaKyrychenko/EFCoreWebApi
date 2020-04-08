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
        #endregion

        #region Constructors
        public TourController(ITourService sqlTourService)
        {
            _TourService = sqlTourService;
        }
        #endregion

        #region APIs
        [Route("Tour")]
        [HttpGet]
        public IEnumerable<Tour> Get()
        {
            return _TourService.GetAll();
        }

        [Route("Tour/{Id}")]
        [HttpGet]
        public Task<Tour> Get(int Id)
        {
            return _TourService.GetById(Id);
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
