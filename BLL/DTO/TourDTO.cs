using System;
using System.Collections.Generic;
using System.Text;

namespace BLL.DTO
{
    public class TourDTO
    {
        public int Id { get; set; }
        public string NameTour { get; set; }
        public string Route { get; set; }
        public string TypeOfTour { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfFinish { get; set; }
        public string TypeOfTransport { get; set; }
        
        public double Price { get; set; }
        public string Description { get; set; }
        public string ImagePath { get; set; }
    }
}
