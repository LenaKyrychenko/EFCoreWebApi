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
        [Route("REservation")]
        [HttpGet]
        public IEnumerable<ReservationDTO> Get()
        {
            var models = _ReservationService.GetAll().ToList();

            return _mapper.Map<List<Reservation>, List<ReservationDTO>>(models);
        }

        [Route("Reservation/{Id}")]
        [HttpGet]
        public ReservationDTO Get(int Id)
        {
            var models = _ReservationService.GetById(Id);
            Reservation reservation = models.Result;

            return _mapper.Map<Reservation, ReservationDTO>(reservation);
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
