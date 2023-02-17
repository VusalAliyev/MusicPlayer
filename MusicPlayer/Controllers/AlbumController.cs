using BusinessLayer.Abstract;
using EntityLayer.DTOs.Album;
using Microsoft.AspNetCore.Mvc;

namespace MusicPlayer.Controllers
{
    public class AlbumController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlbumService _service;

        public AlbumController(ILogger<HomeController> logger, IAlbumService service)
        {
            _logger = logger;
            _service = service;
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var albums = await _service.GetAll();
            return View(albums);
        }


        [HttpPost]
        public async Task<IActionResult> Post(AlbumCreateDTO album)
        {
            await _service.Add(album);
            return RedirectToAction(nameof(Get));
        }
        [HttpPut]
        public async Task<IActionResult> Put(AlbumUpdateDTO album)
        {
            await _service.Update(album);
            return RedirectToAction(nameof(Get));
        }
        [HttpDelete]
        public async Task<IActionResult> Delete(AlbumDeleteDTO album)
        {
            await _service.Delete(album);
            return RedirectToAction(nameof(Get));
        }
    }
}
