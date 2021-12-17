using System.Collections.Generic;
using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;
using Training.DAL.Base;
using Training.DAL.Context;

namespace Training.DAL.Implementations
{
    public class BookRepository : RepositoryBase, IBookRepository
    {

        public BookRepository(TrainingDbContext trainingDbContext)
            : base(trainingDbContext)
        { }


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
