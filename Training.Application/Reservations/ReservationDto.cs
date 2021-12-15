using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Reservations
{
    public class ReservationDto
    {
        public Guid Id { get; set; }
        public DateTime CreationDate { get; set; }
        public DateTime ReturnDate { get; set; }
        public Guid UserId { get; set; }
        public Guid BookId { get; set; }
    }
}
