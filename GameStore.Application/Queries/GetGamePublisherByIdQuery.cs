using GameStore.Application.Queries.Interface;
using GameStore.Application.Repository;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Queries
{
    public class GetGamePublisherByIdQuery : BaseQuery<GamePublisher>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly int _id;

        public GetGamePublisherByIdQuery(IUnitOfWork unitOfWork, int id)
        {
            _unitOfWork = unitOfWork;
            _id = id;
        }

        public override GamePublisher Execute()
        {
            var gamePublisher = _unitOfWork.GamePublishers.GetAll()?.FirstOrDefault(gamePublisher => gamePublisher.Id == _id);
            if (gamePublisher == null)
            {
                throw new ApplicationException($"Publisher with given id: {_id} not found");
            }
            return gamePublisher;
        }

        public override void Validate()
        {
            if (_id <= 0) throw new ArgumentException($"Given id: {_id} is less than 1.");
        }
    }
}
