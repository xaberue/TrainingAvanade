namespace Training.Core.Repositories
{
    public interface IUnitOfWork
    {
        IUserRepository UserRepository { get; }
        IBookRepository BookRepository { get; }
        IReservationRepository ReservationRepository { get; }
        IAlbumRepository AlbumRepository { get; }

        bool CommitTransaction();
    }
}
