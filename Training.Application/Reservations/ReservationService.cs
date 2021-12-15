using System;
using System.Collections.Generic;
using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Reservations
{
    public class ReservationService : IReservationService
    {

        private readonly IReservationRepository _reservationRepository;
        

        public ReservationService(IReservationRepository reservationRepository)
        {
            _reservationRepository = reservationRepository;
        }

        public IEnumerable<ReservationDto> Get(Guid userId)
        {
            return _reservationRepository
                .GetByUser(userId)
                .Select(x => MapEntity(x));
        }

        public void Create(ReservationDto reservationDto)
        {
            var reservation = MapDto(reservationDto);

            _reservationRepository.Create(reservation);
        }

        public void Update(ReservationUpdateDto reservationUpdateDto)
        {
            var reservation = _reservationRepository.GetById(reservationUpdateDto.Id);

            reservation.ExpectedDeliveryDate = reservationUpdateDto.NewExpectedDeliveryDate;

            _reservationRepository.Update(reservation);
        }

        public void Delete(Guid id)
        {
            var reservation = _reservationRepository.GetById(id);

            reservation.IsDeleted = true;

            _reservationRepository.Update(reservation);
        }


        private ReservationDto MapEntity(Reservation entity)
        {
            return new ReservationDto
            {
                Id = entity.Id,
                UserId = entity.UserId,
                BookId = entity.BookId,
                CreationDate = entity.CreationDate,
                ExpectedDeliveryDate = entity.ExpectedDeliveryDate,
            };
        }

        private Reservation MapDto(ReservationDto entity)
        {
            return new Reservation
            {
                Id = entity.Id,
                UserId = entity.UserId,
                BookId = entity.BookId,
                CreationDate = entity.CreationDate,
                ExpectedDeliveryDate = entity.ExpectedDeliveryDate,
            };
        }

    }
}
