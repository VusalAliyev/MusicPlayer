using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;
using MusicPlayer.Models;
using System.Diagnostics;

namespace MusicPlayer.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IPlaylistService _playlistService;
        public HomeController(ILogger<HomeController> logger, IPlaylistService playlistService)
        {
            _logger = logger;
            _playlistService = playlistService;
        }

        public async Task<IActionResult> Index()
        {
            var playlists = await _playlistService.GetAll();
            return View(playlists);
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