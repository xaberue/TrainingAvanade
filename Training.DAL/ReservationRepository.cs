using System;
using System.Collections.Generic;
using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class ReservationRepository : IReservationRepository
    {

        private List<Reservation> _reservations;


        public ReservationRepository()
        {
            _reservations = new List<Reservation> 
            { 
                new Reservation{ Id = Guid.NewGuid(), UserId = Guid.Parse("4c3b999f-64a5-4dce-a08c-c0d426944240"), CreationDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.Now.AddDays(15), BookId = Guid.NewGuid() },
                new Reservation{ Id = Guid.NewGuid(), UserId = Guid.Parse("4c3b999f-64a5-4dce-a08c-c0d426944240"), CreationDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.Now.AddDays(15), BookId = Guid.NewGuid() },
                new Reservation{ Id = Guid.NewGuid(), UserId = Guid.Parse("84d9e693-2340-4a96-886e-4eb410ca6bfe"), CreationDate = DateTime.UtcNow, ExpectedDeliveryDate = DateTime.Now.AddDays(15), BookId = Guid.NewGuid() }
            };
        }


        public void Create(Reservation reservation)
        {
            _reservations.Add(reservation);
        }

        public Reservation GetById(Guid reservationId)
        {
            return _reservations.FirstOrDefault(x => x.Id == reservationId);
        }

        public IEnumerable<Reservation> GetByUser(Guid userId)
        {
            return _reservations.Where(x => x.UserId == userId && !x.IsDeleted);
        }

        public void Update(Reservation reservation)
        {
            _reservations = _reservations.Where(x => x.Id != reservation.Id).ToList();

            _reservations.Add(reservation);
        }
    }
}
