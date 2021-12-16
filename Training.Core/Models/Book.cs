using System;
using System.Collections.Generic;
using System.Linq;
using Training.Core.Contracts;

namespace Training.Core.Models
{
    public class Book : IRemovable
    {

        public Guid Id { get; set; }
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public bool IsDeleted { get; set; }

        public ICollection<Reservation> Reservations { get; set; }

        public Book()
        {
            Reservations = Enumerable.Empty<Reservation>().ToList();
        }
    }
}
