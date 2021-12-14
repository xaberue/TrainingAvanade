using System.Collections.Generic;
using Training.Core.Models;

namespace Training.Application.Books
{
    public interface IBookService
    {
        IEnumerable<Book> Get();
        void Create(Book book);
        void Update(Book book);
    }
}