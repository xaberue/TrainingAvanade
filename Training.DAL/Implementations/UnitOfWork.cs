using Training.Core.Repositories;
using Training.DAL.Context;

namespace Training.DAL.Implementations
{
    public class UnitOfWork : IUnitOfWork
    {

        private IUserRepository _userRepository;
        private IBookRepository _bookRepository;
        private IReservationRepository _reservationRepository;
        private IAlbumRepository _albumRepository;

        private readonly TrainingDbContext _context;


        public UnitOfWork(TrainingDbContext context)
        {
            _context = context;
        }

        public IUserRepository UserRepository 
        { 
            get 
            {
                if (_userRepository == null)
                    _userRepository = new UserRepository(_context);
                return _userRepository; 
            }
        }

        public IBookRepository BookRepository
        {
            get
            {
                if (_bookRepository == null)
                    _bookRepository = new BookRepository(_context);
                return _bookRepository;
            }
        }

        public IReservationRepository ReservationRepository
        {
            get
            {
                if (_reservationRepository == null)
                    _reservationRepository = new ReservationRepository(_context);
                return _reservationRepository;
            }
        }

        public IAlbumRepository AlbumRepository
        {
            get
            {
                if (_albumRepository == null)
                    _albumRepository = new AlbumRepository(_context);
                return _albumRepository;
            }
        }

        public bool CommitTransaction()
        {
            return _context.SaveChanges() > 0;
        }
    }
}
