using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Training.Application.Albums;

namespace Training.WebAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/[controller]")]

    public class AlbumController : ControllerBase
    {
        private readonly IAlbumService _albumService;

        public AlbumController(IAlbumService albumService)
        {
            _albumService = albumService;
        }


        [HttpGet]
        public IActionResult Get()
        {
            var books = _albumService.Get();

            return Ok(books);
        }

        [HttpGet("{id}")]
        public IActionResult Get(string id)
        {
            var book = _albumService.Get(id);

            return Ok(book);
        }

        [HttpPost]
        public IActionResult Post(AlbumDto album)
        {
            _albumService.Create(album);

            return Ok();
        }
    }
}
