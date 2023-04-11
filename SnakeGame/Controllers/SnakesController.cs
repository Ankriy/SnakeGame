using Microsoft.AspNetCore.Mvc;
using PocketSafe.Logic.Models.Games;
using SnakeGame.Logic;
using SnakeGame.Models;
using System.Diagnostics;

namespace SnakeGame.Controllers
{
    public class SnakesController : Controller
    {
        private readonly GameService _gameService;
        public SnakesController(GameService gameService)
        {
            _gameService = gameService;
        }
        public IActionResult Snake()
        {
            return View();
        }
        
        public IActionResult SnakeAdd(string looser)
        {
            _gameService.AddGame(new GameCreateDTO() { Looser = looser });
            return View();
        }
        public IActionResult Refreh()
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