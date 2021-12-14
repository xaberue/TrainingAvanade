using Microsoft.AspNetCore.Mvc;
using Training.Application.Books;
using Training.Core.Models;

namespace Training.WebAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BookController : ControllerBase
    {

        private readonly IBookService _bookService;


        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }


        [HttpGet]
        public IActionResult Get() 
        {
            var books = _bookService.Get();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var book = _bookService.Get(id);

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post(Book book)
        {
            _bookService.Create(book);

            return Ok();
        }

        [HttpPut]
        public IActionResult Put(Book book) 
        {
            _bookService.Update(book);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(int id) 
        {
            _bookService.Delete(id);

            return Ok();
        }

    }
}
