using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class Tour : BaseEntity
    {
        public string NameTour { get; set; }
        public string Route { get; set; }
        public int TypeOfTourId { get; set; }
        public DateTime DateOfStart { get; set; }
        public DateTime DateOfFinish { get; set; }
        public int TypeOfTransportId { get; set; }
        public double Price { get; set; }

        public ICollection<Reservation> Reservations { get; set; }
        public TypesOfTransport TypesOfTransport { get; set; }
        public TypesOfTour TypesOfTour { get; set; }
    }
}
