using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class TypesOfTour
    {
        public int Id { get; set; }
        public string TypeOfTour { get; set; }

        public ICollection<Tour> Tours { get; set; }
    }
}
