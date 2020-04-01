using ClassLibrary1.Entities;
using ClassLibrary1.Interfaces.IServices;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplicationEF.Controllers
{
    public class ReservationController : ControllerBase
    {
        #region Propertirs
        IReservationService _ReservationService;
        #endregion

        #region Constructors
        public ReservationController(IReservationService sqlOrderService)
        {
            _ReservationService = sqlOrderService;
        }
        #endregion

        #region APIs
        [Route("REservation")]
        [HttpGet]
        public IEnumerable<Reservation> Get()
        {
            return _ReservationService.GetAll();
        }

        [Route("Reservation/{Id}")]
        [HttpGet]
        public Reservation Get(int Id)
        {
            return _ReservationService.GetById(Id);
        }

        [Route("Reservation")]
        [HttpPost]
        public void Post([FromBody]Reservation order)
        {
            _ReservationService.Add(order);
        }

        [Route("Reservation/{Id}")]
        [HttpDelete]
        public void Delete(int id)
        {
            _ReservationService.Delete(id);
        }

        #endregion
    }
}
