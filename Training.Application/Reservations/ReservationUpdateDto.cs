using System;

namespace Training.Application.Reservations
{
    public class ReservationUpdateDto
    {
        public Guid Id { get; set; }
        public DateTime NewExpectedDeliveryDate { get; set; }
    }
}
