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
    public class ReservationController : ControllerBase
    {
        #region Propertirs
        IReservationService _ReservationService;
        private readonly IMapper _mapper;
        #endregion

        #region Constructors
        public ReservationController(IReservationService sqlReservationService, IMapper mapper)
        {
            _ReservationService = sqlReservationService;
            _mapper = mapper;
        }
        #endregion

        #region APIs
        [Route("Reservation")]
        [HttpGet]
        public IActionResult Get()
        {
            var models = _ReservationService.GetAll().ToList();
            var list = _mapper.Map<List<Reservation>, List<ReservationDTO>>(models);

            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
        }

        [Route("Reservation/{Id}")]
        [HttpGet]
        public IActionResult Get(int Id)
        {
            var models = _ReservationService.GetById(Id);
            Reservation reservation = models.Result;

            var list = _mapper.Map<Reservation, ReservationDTO>(reservation);

            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
        }

        [Route("Reservation")]
        [HttpPost]
        public void Post([FromBody]Reservation reservation)
        {
            _ReservationService.Add(reservation);
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
