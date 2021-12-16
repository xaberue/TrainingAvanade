using System;

namespace Training.Application.Reservations
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        public string BookISBN { get; set; }
        public string UserIdentifier { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ExpectedDeliveryDate { get; set; }
    }
}
