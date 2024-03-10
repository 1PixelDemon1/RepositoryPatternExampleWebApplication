using GameStore.Application.Commands.Interface;
using GameStore.Application.Repository;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Commands
{
    public class AddGamePublisherCommand : BaseCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly GamePublisher _gamePublisher;

        public AddGamePublisherCommand(IUnitOfWork unitOfWork, GamePublisher gamePublisher)
        {
            _unitOfWork = unitOfWork;
            _gamePublisher = gamePublisher;
        }

        public override void Execute()
        {
            _unitOfWork.GamePublishers.Add(_gamePublisher);
            _unitOfWork.SaveChanges();
        }

        public override void Validate()
        {
            _gamePublisher.Validate();
        }
    }
}
