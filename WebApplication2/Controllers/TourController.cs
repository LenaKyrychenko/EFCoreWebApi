using AutoMapper;
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
    [Route("api/[controller]")]
    [ApiController]
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
        //[Route("Tour")]
        [HttpGet]
        public ActionResult<List<TourDTO>> Get([FromQuery] PagingParameters pagingParameters)
        {
            var list = _TourService.GetAll(pagingParameters).ToList();

            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
        }

        [Route("Filter")]
        [HttpGet]
        public ActionResult<List<TourDTO>> GetFilter([FromQuery] PagingParameters pagingParameters)
        {
            var list = _TourService.GetFilter(pagingParameters).ToList();


            if (list == null)
                return NotFound("Information not found");
            else
                return Ok(list);
        }

        [Route("Tour/{Id}")]
        [HttpGet]
        public async Task<IActionResult> Get(int Id)
        {
            Tour models = await _TourService.GetById(Id);
            
            var list = _mapper.Map<Tour, TourDTO>(models);

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
