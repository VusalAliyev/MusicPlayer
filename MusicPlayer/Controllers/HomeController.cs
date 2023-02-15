using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.DTOs.Album;
using Microsoft.AspNetCore.Mvc;
using MusicPlayer.Models;
using System.Diagnostics;

namespace MusicPlayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IAlbumService _service;

        public HomeController(ILogger<HomeController> logger, IAlbumService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            var albums =await _service.GetAll();
            return View(albums);
        }
        [HttpPost]
        public async Task<IActionResult> Post(AlbumCreateDTO album)
        {
            await _service.Add(album);
            return View(RedirectToAction(nameof(Index)));
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}