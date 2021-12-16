using System;
using System.Collections.Generic;
using System.Linq;
using Training.Application.Base;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Reservations
{
    public class ReservationService : ServiceBase, IReservationService
    {

        private readonly IReservationRepository _reservationRepository;
        private readonly IBookRepository _bookRepository;
        private readonly IUserRepository _userRepository;


        public ReservationService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _reservationRepository = unitOfWork.ReservationRepository;
            _bookRepository = unitOfWork.BookRepository;
            _userRepository = unitOfWork.UserRepository;
        }

        public IEnumerable<ReservationDto> Get(Guid userId)
        {
            return _reservationRepository
                .GetByUser(userId)
                .Select(x => MapEntity(x));
        }

        public void Create(ReservationDto reservationDto)
        {
            var book = _bookRepository.Get(reservationDto.BookISBN);
            var user = _userRepository.Get(reservationDto.UserIdentifier);
            var reservation = MapDto(reservationDto, book, user);

            reservation.Id = Guid.NewGuid();

            _reservationRepository.Create(reservation);
            _unitOfWork.CommitTransaction();
        }

        public void Update(ReservationUpdateDto reservationUpdateDto)
        {
            var reservation = _reservationRepository.GetById(reservationUpdateDto.Id);

            reservation.ExpectedDeliveryDate = reservationUpdateDto.NewExpectedDeliveryDate;

            _reservationRepository.Update(reservation);
            _unitOfWork.CommitTransaction();
        }

        public void Delete(Guid id)
        {
            var reservation = _reservationRepository.GetById(id);

            reservation.IsDeleted = true;

            _reservationRepository.Update(reservation);
            _unitOfWork.CommitTransaction();
        }


        private ReservationDto MapEntity(Reservation entity)
        {
            return new ReservationDto
            {
                Id = entity.Id,
                UserIdentifier = entity.User.NationalIdentifier,
                BookISBN = entity.Book.ISBN,
                CreationDate = entity.CreationDate,
                ExpectedDeliveryDate = entity.ExpectedDeliveryDate,
            };
        }

        private Reservation MapDto(ReservationDto entity, Book book, User user)
        {
            return new Reservation
            {
                Id = entity.Id,
                User = user,
                Book = book,
                CreationDate = entity.CreationDate,
                ExpectedDeliveryDate = entity.ExpectedDeliveryDate,
            };
        }

    }
}
