using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Reservations
{
    public class ReservationUpdateDto
    {
        public Guid Id { get; set; }
        public DateTime NewReturnDate { get; set; }
    }
}
