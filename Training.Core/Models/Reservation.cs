using System;
using Training.Core.Contracts;

namespace Training.Core.Models
{
    public class Reservation : IRemovable
    {

        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }

        public Book Book { get; set; }
        public User User { get; set; }

        public bool IsDeleted { get; set; }
    }
}
