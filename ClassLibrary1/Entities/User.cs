using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary1.Entities
{
    public class User : IdentityUser
    {
        public string Surname { get; set; }
        public string City { get; set; }
        public string Phone { get; set; }
        public ICollection<Reservation> Reservations { get; set; }
    }
}
