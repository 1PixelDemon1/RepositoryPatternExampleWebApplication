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
    public class GetGameByIdQuery : BaseQuery<Game>
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly int _id;

        public GetGameByIdQuery(IUnitOfWork unitOfWork, int id)
        {
            _unitOfWork = unitOfWork;
            _id = id;
        }

        public override Game Execute()
        {
            var game = _unitOfWork.Games.GetAll()?.FirstOrDefault(game => game.Id == _id);
            if (game == null)
            {
                throw new ApplicationException($"Unable to find game with given id: {_id}");
            }
            return game;
        }

        public override void Validate()
        {
            if(_id <= 0) throw new ArgumentException($"Given id: {_id} is less than 1.");
        }
    }
}
