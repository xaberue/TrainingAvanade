using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training.Core.Repositories
{
    public interface IUnitOfWork
    {
        public IUserRepository UserRepository { get; }
        public IBookRepository BookRepository { get; }
        public IReservationRepository ReservationRepository { get; }

        bool CommitTransaction();
    }
}
