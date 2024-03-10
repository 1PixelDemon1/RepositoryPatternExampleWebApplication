using GameStore.Application.Commands.Interface;
using GameStore.Application.Queries;
using GameStore.Application.Repository;
using GameStore.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Application.Commands
{
    public class RemoveGameCommand : BaseCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly int _id;

        public RemoveGameCommand(IUnitOfWork unitOfWork, int id)
        {
            _unitOfWork = unitOfWork;
            _id = id;
        }

        public override void Execute()
        {
            var game = _unitOfWork.Games.GetAll()?.FirstOrDefault(game => game.Id == _id);
            if (game == null)
            {
                throw new ApplicationException($"Game with given id: {_id} not found");
            }
            _unitOfWork.Games.Remove(game);
            _unitOfWork.SaveChanges();
        }

        public override void Validate()
        {
            if (_id <= 0) throw new ArgumentException($"Given id: {_id} is less than 1.");
        }
    }
}
