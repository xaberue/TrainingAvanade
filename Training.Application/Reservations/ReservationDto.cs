using System;

namespace Training.Application.Reservations
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        public Guid BookId { get; set; }
        public Guid UserId { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
    }
}
