using GameStore.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using RemoteStorageAPI.Services;
using System.Net.Http.Headers;

namespace RemoteStorageAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class GamePublisherController : ControllerBase
    {
        private readonly ITemporaryStorage<GamePublisher> _publishers;

        public GamePublisherController(ITemporaryStorage<GamePublisher> publishers)
        {
            _publishers = publishers;
        }

        [HttpGet(nameof(GetGamePublishers))]
        public IEnumerable<GamePublisher> GetGamePublishers()
        {
            return _publishers.GetAll();
        }

        [HttpPost(nameof(AddGamePublisher))]
        public void AddGamePublisher([FromBody] GamePublisher gamePublisher)
        {
            gamePublisher.Id = _publishers.Count() + 1;
            _publishers.Add(gamePublisher);
        }

        [HttpPost(nameof(RemoveGamePublisher))]
        public void RemoveGamePublisher([FromBody] GamePublisher gamePublisher)
        {
            _publishers.Remove(gamePublisher);
        }

        [HttpPost(nameof(UpdateGamePublisher))]
        public void UpdateGamePublisher([FromBody] GamePublisher gamePublisher)
        {
            var currentPublisher = _publishers.FirstOrDefault(pub => pub.Id == gamePublisher.Id);
            if (currentPublisher != null)
            {
                _publishers.Remove(currentPublisher);
                _publishers.Add(gamePublisher);
            }
        }
    }
}
