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
        #endregion

        #region Constructors
        public TypesOfTourController(ITypesOfTourService sqlTypesOfTourService)
        {
            _TypesOfTourService = sqlTypesOfTourService;
        }
        #endregion

        #region APIs
        [Route("TypesOfTour")]
        [HttpGet]
        public IEnumerable<TypesOfTour> Get()
        {
            return _TypesOfTourService.GetAll();
        }

        [Route("TypesOfTour/{Id}")]
        [HttpGet]
        public Task<TypesOfTour> Get(int Id)
        {
            return _TypesOfTourService.GetById(Id);
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
