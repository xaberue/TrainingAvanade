using System;
using System.Collections.Generic;
using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class ReservationRepository : IReservationRepository
    {

        private readonly TrainingDbContext _trainingDbContext;


        public ReservationRepository(TrainingDbContext trainingDbContext)
        {
            _trainingDbContext = trainingDbContext;
        }


        public void Create(Reservation reservation)
        {
            _trainingDbContext.Reservations
                .Add(reservation);
        }

        public Reservation GetById(Guid reservationId)
        {
            return _trainingDbContext.Reservations
                .FirstOrDefault(x => x.Id == reservationId);
        }

        public IEnumerable<Reservation> GetByUser(User user)
        {
            return _trainingDbContext.Reservations
                .Where(x => x.User == user);
        }

        public void Update(Reservation reservation)
        {
            _trainingDbContext.Reservations.Update(reservation);
        }
    }
}
