using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class TourViewModel
    {
        public int id { get; set; }
        public string nameTour { get; set; }
        public string route { get; set; }
        public string typeOfTour { get; set; }
        public DateTime dateOfStart { get; set; }
        public DateTime dateOfFinish { get; set; }
        public string typeOfTransport { get; set; }
        public double price { get; set; }
        public string description { get; set; }
        public string imagePath { get; set; }
    }
}
