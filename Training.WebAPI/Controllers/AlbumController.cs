using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Training.Application.Albums;

namespace Training.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [Authorize]
    [ApiController]
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
            var albums = _albumService.Get();
            return Ok(albums);
        }

        [HttpGet("{title}")]
        public IActionResult Get(string title)
        {
            var album = _albumService.Get(title);

            return Ok(album);
        }

        [HttpPut]
        public IActionResult Put(AlbumDto album)
        {
            _albumService.Update(album);
            return Ok();
        }

        [HttpPost]
        public IActionResult Post(AlbumDto album)
        {
            _albumService.Create(album);

            return Ok();
        }

        [HttpDelete]
        public IActionResult Delete(string title)
        {
            _albumService.Delete(title);

            return Ok();
        }
    }
}
