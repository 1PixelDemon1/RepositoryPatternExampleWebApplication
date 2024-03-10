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
    public class RemoveGamePublisherCommand : BaseCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly int _id;

        public RemoveGamePublisherCommand(IUnitOfWork unitOfWork, int id)
        {
            _unitOfWork = unitOfWork;
            _id = id;
        }

        public override void Execute()
        {
            var gamePublisher = _unitOfWork.GamePublishers.GetAll()?.FirstOrDefault(gamePublisher => gamePublisher.Id == _id);
            if (gamePublisher == null)
            {
                throw new ApplicationException($"Publisher with given id: {_id} not found");
            }
            _unitOfWork.GamePublishers.Remove(gamePublisher);
            _unitOfWork.SaveChanges();
        }

        public override void Validate()
        {
            if (_id <= 0) throw new ArgumentException($"Given id: {_id} is less than 1.");
        }
    }
}
