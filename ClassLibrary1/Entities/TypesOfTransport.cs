using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class TypesOfTransport : BaseEntity
    {
        public string TypeOfTransport { get; set; }

        public ICollection<Tour> Tours { get; set; }
    }
}
