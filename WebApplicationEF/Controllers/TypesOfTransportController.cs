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
        #endregion

        #region Constructors
        public TypesOfTransportController(ITypesOfTransportService sqlTypesOfTransportService)
        {
            _TypesOfTransportService = sqlTypesOfTransportService;
        }
        #endregion

        #region APIs
        [Route("TypesOfTransport")]
        [HttpGet]
        public IEnumerable<TypesOfTransport> Get()
        {
            return _TypesOfTransportService.GetAll();
        }

        [Route("TypesOfTransport/{Id}")]
        [HttpGet]
        public Task<TypesOfTransport> Get(int Id)
        {
            return _TypesOfTransportService.GetById(Id);
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
