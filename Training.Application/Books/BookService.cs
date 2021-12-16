using System;
using System.Collections.Generic;
using System.Linq;
using Training.Application.Base;
using Training.Core.Models;
using Training.Core.Repositories;

namespace Training.Application.Books
{
    public class BookService : ServiceBase, IBookService
    {

        private readonly IBookRepository _bookRepository;


        public BookService(IUnitOfWork unitOfWork)
            : base(unitOfWork)
        {
            _bookRepository = unitOfWork.BookRepository;
        }


        public void Create(BookDto dto)
        {
            var book = Map(dto);

            book.Id = Guid.NewGuid();

            _bookRepository.Create(book);
            _unitOfWork.CommitTransaction();
        }

        public IEnumerable<BookDto> Get()
        {
            return _bookRepository.Get().Select(MapEntity);
        }

        public BookDto Get(string isbn)
        {
            return MapEntity(_bookRepository.Get(isbn));
        }

        public void Update(BookDto dto)
        {
            var book = _bookRepository.Get(dto.ISBN);

            book.Author = dto.Author;
            book.Name = dto.Name;

            _bookRepository.Update(book);
            _unitOfWork.CommitTransaction();
        }

        public void Delete(string isbn)
        {
            var book = _bookRepository.Get(isbn);

            book.IsDeleted = true;

            _bookRepository.Update(book);
            _unitOfWork.CommitTransaction();
        }


        private Book Map(BookDto dto) 
        {
            return new Book
            {
                ISBN = dto.ISBN,
                Name = dto.Name,
                Author = dto.Author
            };
        }

        private BookDto MapEntity(Book dto)
        {
            return new BookDto
            {
                ISBN = dto.ISBN,
                Name = dto.Name,
                Author = dto.Author
            };
        }
    }
}
