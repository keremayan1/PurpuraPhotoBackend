using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AlbumsController : ControllerBase
    {
        private IAlbumService _albumService;
        public AlbumsController(IAlbumService albumService)
        {
            _albumService = albumService;
        }
        [HttpPost]
        public async Task<IActionResult> Add(Album album)
        {
            var result = await _albumService.Add(album);
            if(!result.Success) 
                return BadRequest(result);
            return Ok(result);
        }

        [HttpPut]
        public async Task<IActionResult> Update(Album album)
        {
            var result = await _albumService.Update(album);
            if(!result.Success)
                return BadRequest(result);
            return Ok(result);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _albumService.Delete(id);
            if(!result.Success)
                return BadRequest(result);
            return Ok(result);
        }
    }
}
