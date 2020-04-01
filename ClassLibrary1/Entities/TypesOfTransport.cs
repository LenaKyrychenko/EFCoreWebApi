using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class TypesOfTransport
    {
        public int Id { get; set; }
        public string TypeOfTransport { get; set; }

        public ICollection<Tour> Tours { get; set; }
    }
}
