using System;
using System.Collections.Generic;
using System.Linq;

namespace Training.Core.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string NationalIdentifier { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }

        public ICollection<Reservation> Reservations { get; set; }


        public User()
        {
            Reservations = Enumerable.Empty<Reservation>().ToList();
        }
    }
}
