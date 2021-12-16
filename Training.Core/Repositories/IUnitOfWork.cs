namespace Training.Core.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IBookRepository BookRepository { get; }
        IReservationRepository ReservationRepository { get; }

        bool CommitTransaction();
    }
}
