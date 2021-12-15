using System;
using System.Collections.Generic;
using System.Linq;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.DAL
{
    public class BookRepository : IBookRepository
    {

        private List<Book> _books;


        public BookRepository()
        {
            _books = new List<Book>();

            for (int i = 0; i < 5; i++)
                _books.Add(new Book { Id = Guid.NewGuid(), ISBN = $"XXX-{i}{i}", Name = $"Book {i}", Author = $"Author {i}" });
        }


        public void Create(Book book)
        {
            _books.Add(book);
        }

        public IEnumerable<Book> Get()
        {
            return _books.Where(x => !x.IsDeleted);
        }

        public Book Get(string isbn)
        {
            return _books.FirstOrDefault(x => x.ISBN == isbn);
        }


        public void Update(Book book)
        {
            _books = _books.Where(x => x.Id != book.Id).ToList();

            _books.Add(book);
        }
    }
}
