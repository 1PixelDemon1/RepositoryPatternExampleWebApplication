using GameStore.Application.Services.Interface;
using GameStore.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GameStore.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamePublisherController : ControllerBase
    {
        private readonly IGamePublisherService _gamePublisherService;

        public GamePublisherController(IGamePublisherService gamePublisherService)
        {
            _gamePublisherService = gamePublisherService;
        }

        [HttpGet(nameof(Get))]
        public GamePublisher Get(int id)
        {
            return _gamePublisherService.GetGamePublisherById(id);
        }

        [HttpGet(nameof(GetAll))]
        public IEnumerable<GamePublisher> GetAll()
        {
            return _gamePublisherService.GetAllGamePublishers();
        }

        [HttpPost(nameof(AddGamePublisher))]
        public void AddGamePublisher([FromBody] GamePublisher gamePublisher)
        {
            _gamePublisherService.AddGamePublisher(gamePublisher);
        }

        [HttpPost(nameof(UpdateGamePublisher))]
        public void UpdateGamePublisher([FromBody] GamePublisher gamePublisher)
        {
            _gamePublisherService.UpdateGamePublisher(gamePublisher);
        }

        [HttpPost(nameof(RemoveGamePublisher))]
        public void RemoveGamePublisher(int id)
        {
            _gamePublisherService.RemoveGamePublisher(id);
        }

        [HttpPost(nameof(SeedGamePublishers))]
        public void SeedGamePublishers()
        {
            _gamePublisherService.SeedGamePublishers();
        }

    }
}
