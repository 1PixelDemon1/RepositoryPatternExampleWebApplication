using GameStore.Application.Services.Interface;
using GameStore.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GameController : ControllerBase
    {
        private readonly IGameService _gameService;

        public GameController(IGameService gameService) 
        {
            _gameService = gameService;
        }

        [HttpGet(nameof(Get))]
        public Game Get(int id)
        {
            return _gameService.GetGameById(id);
        }
        
        [HttpGet(nameof(GetAll))]
        public IEnumerable<Game> GetAll()
        {
            return _gameService.GetAllGames();
        }

        [HttpPost(nameof(AddGame))]
        public void AddGame([FromBody] Game game)
        {
            _gameService.AddGame(game);
        }
        
        [HttpPost(nameof(UpdateGame))]
        public void UpdateGame([FromBody] Game game)
        {
            _gameService.UpdateGame(game);
        }
        
        [HttpPost(nameof(RemoveGame))]
        public void RemoveGame(int id)
        {
            _gameService.RemoveGame(id);
        }

        [HttpPost(nameof(SeedGames))]
        public void SeedGames()
        {
            _gameService.SeedGames();
        }
    }
}
