using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class Reservation : BaseEntity
    {
        
        public string TourId { get; set; }
        public string UserId { get; set; }
        public int NumberOfPeople { get; set; }
        public double Sum { get; set; }

        public User User { get; set; }
        public Tour Tour { get; set; }
    }
}
