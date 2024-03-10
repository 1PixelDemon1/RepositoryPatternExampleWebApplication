using GameStore.Application.Repository;
using GameStore.Domain.Entities;
using GameStore.Infrastructure.RemoteRepository.HttpHandler;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.RemoteRepository
{
    public class GamePublisherRemoteRepository : IRepository<GamePublisher>
    {
        private readonly IHttpHandler _httpHandler;
        private string _baseUri;

        public GamePublisherRemoteRepository(IHttpHandler httpHandler)
        {
            _httpHandler = httpHandler;
            _baseUri = "https://localhost:7171/api/GamePublisher/";
        }

        public void Add(GamePublisher value)
        {
            _httpHandler.Request(HttpMethod.Post, _baseUri + "AddGamePublisher", value);
        }

        public IEnumerable<GamePublisher>? GetAll()
        {
            return _httpHandler.Request<IEnumerable<GamePublisher>>(HttpMethod.Get, _baseUri + "GetGamePublishers");
        }

        public void Remove(GamePublisher value)
        {
            _httpHandler.Request(HttpMethod.Post, _baseUri + "RemoveGamePublisher", value);
        }

        public void Update(GamePublisher value)
        {
            _httpHandler.Request(HttpMethod.Post, _baseUri + "UpdateGamePublisher", value);
        }
    }
}
