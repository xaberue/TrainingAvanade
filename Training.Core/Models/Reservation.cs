using System;
using Training.Core.Contracts;

namespace Training.Core.Models
{
    public class Reservation : IRemovable
    {

        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }

        public bool IsDeleted { get; set; }
    }
}
