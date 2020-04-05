using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class ReservationDTO
    {
        public string TourId { get; set; }
        public int UserId { get; set; }
        public double Sum { get; set; }
    }
}
