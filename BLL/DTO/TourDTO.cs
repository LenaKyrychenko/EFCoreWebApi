using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class TourDTO
    {
        public string NameTour { get; set; }
        public string Route { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfFinish { get; set; }
        public double Price { get; set; }
    }
}
