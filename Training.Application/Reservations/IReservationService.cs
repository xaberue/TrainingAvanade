using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Application.Reservations
{
    public interface IReservationService
    {
        IEnumerable<ReservationDto> Get(Guid userId);
        void Create(ReservationDto reservationDto);
        void Update(ReservationUpdateDto reservationUpdateDto);
        void Delete(Guid id);
    }
}
