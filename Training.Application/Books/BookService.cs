using System.Collections.Generic;
using System.Linq;
using Training.Core.Models;

namespace Training.Application.Books
{
    public class BookService : IBookService
    {

        private List<Book> _books;


        public BookService()
        {
            _books = new List<Book>();

            for (int i = 0; i < 5; i++)
                _books.Add(new Book { Id = i, ISBN = $"XXX-{i}{i}", Name = $"Book {i}", Author = $"Author {i}" });
        }

        public void Create(Book book)
        {
            _books.Add(book);
        }

        public IEnumerable<Book> Get()
        {
            return _books;
        }

        public Book Get(int id)
        {
            return _books.FirstOrDefault(x => x.Id == id);
        }

        public void Update(Book book)
        {
            _books = _books.Where(x => x.Id != book.Id).ToList();

            _books.Add(book);
        }

        public void Delete(int id)
        {
            _books = _books.Where(x => x.Id != id).ToList();
        }
    }
}
