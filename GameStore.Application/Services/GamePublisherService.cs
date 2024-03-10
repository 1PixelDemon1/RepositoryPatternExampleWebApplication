using GameStore.Application.Commands;
using GameStore.Application.Queries;
using GameStore.Application.Repository;
using GameStore.Application.Services.Interface;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Services
{
    public class GamePublisherService : IGamePublisherService
    {
        private readonly IUnitOfWork _unitOfWork;
        
        public GamePublisherService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public void AddGamePublisher(GamePublisher gamePublisher)
        {
            new AddGamePublisherCommand(_unitOfWork, gamePublisher).Handle();
        }

        public IEnumerable<GamePublisher> GetAllGamePublishers()
        {
            return new GetAllGamePublishersQuery(_unitOfWork).Handle();
        }

        public GamePublisher GetGamePublisherById(int id)
        {
            return new GetGamePublisherByIdQuery(_unitOfWork, id).Handle();
        }

        public void RemoveGamePublisher(int id)
        {
            new RemoveGamePublisherCommand(_unitOfWork, id).Handle();
        }

        public void SeedGamePublishers()
        {
            new SeedGamePublishersCommand(_unitOfWork).Handle();
        }

        public void UpdateGamePublisher(GamePublisher gamePublisher)
        {
            new UpdateGamePublisherCommand(_unitOfWork, gamePublisher).Handle();
        }
    }
}
