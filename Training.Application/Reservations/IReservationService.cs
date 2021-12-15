using System;
using System.Collections.Generic;

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