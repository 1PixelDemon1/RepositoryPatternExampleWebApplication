using GameStore.Application.Commands;
using GameStore.Application.Queries;
using GameStore.Application.Repository;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Services.Interface
{
    public interface IGamePublisherService
    {
        IEnumerable<GamePublisher> GetAllGamePublishers();
        GamePublisher GetGamePublisherById(int id);
        void UpdateGamePublisher(GamePublisher gamePublisher);
        void RemoveGamePublisher(int id);
        void AddGamePublisher(GamePublisher gamePublisher);
        void SeedGamePublishers();
    }
}
