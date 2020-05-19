using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Models
{
    public class TourViewModel
    {
        public string nameTour { get; set; }
        public string route { get; set; }
        public DateTime dateOfStart { get; set; }
        public DateTime dateOfFinish { get; set; }
        public double price { get; set; }
    }
}
