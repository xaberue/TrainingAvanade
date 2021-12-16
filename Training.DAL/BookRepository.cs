using System.Collections.Generic;
using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class BookRepository : IBookRepository
    {

        private readonly TrainingDbContext _trainingDbContext;


        public BookRepository(TrainingDbContext trainingDbContext)
        {
            _trainingDbContext = trainingDbContext;
        }


        public void Create(Book book)
        {
            _trainingDbContext.Books
                .Add(book);
        }

        public IEnumerable<Book> Get()
        {
            return _trainingDbContext.Books
                .Where(x => !x.IsDeleted);
        }

        public Book Get(string isbn)
        {
            return _trainingDbContext.Books
                .FirstOrDefault(x => x.ISBN == isbn);
        }


        public void Update(Book book)
        {
            _trainingDbContext.Books
                .Update(book);
        }
    }
}
