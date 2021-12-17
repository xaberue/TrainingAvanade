using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;
using Training.DAL.Base;
using Training.DAL.Context;

namespace Training.DAL.Implementations
{
    public class ReservationRepository : RepositoryBase, IReservationRepository
    {

        public ReservationRepository(TrainingDbContext trainingDbContext)
             : base(trainingDbContext)
        { }


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

        public IEnumerable<Reservation> GetByUser(Guid userId)
        {
            return _trainingDbContext.Users
                .Include(x => x.Reservations).ThenInclude(x => x.Book)
                .FirstOrDefault(x => x.Id == userId)
                .Reservations
                .Where(x => !x.IsDeleted);
        }

        public void Update(Reservation reservation)
        {
            _trainingDbContext.Reservations.Update(reservation);
        }
    }
}
