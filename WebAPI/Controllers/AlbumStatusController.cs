using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AlbumStatusController : ControllerBase
    {
        private IAlbumStatusService _albumStatusService;

        public AlbumStatusController(IAlbumStatusService albumStatusService)
        {
            _albumStatusService = albumStatusService;
        }
        [HttpPost]
        public async Task<IActionResult> Add(AlbumStatus albumStatus)
        {
            var result = await _albumStatusService.Add(albumStatus);
            if (!result.Success)
                return BadRequest(result);

            return Ok(result);

        }
    }
}
