using System.Collections.Generic;
using Training.Core.Models;

namespace Training.Application.Books
{
    public interface IBookService
    {
        IEnumerable<BookDto> Get();
        BookDto Get(string isbn);
        void Update(BookDto book);
        void Create(BookDto book);
        void Delete(string isbn);
    }
}