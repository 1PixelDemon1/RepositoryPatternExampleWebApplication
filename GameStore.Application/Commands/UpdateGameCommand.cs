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
    public class UpdateGameCommand : BaseCommand
    {

        private readonly IUnitOfWork _unitOfWork;
        private readonly Game _game;

        public UpdateGameCommand(IUnitOfWork unitOfWork, Game game)
        {
            _unitOfWork = unitOfWork;
            _game = game;
        }

        public override void Execute()
        {
            _unitOfWork.Games.Update(_game);
            _unitOfWork.SaveChanges();
        }

        public override void Validate()
        {
            _game.Validate();
        }
    }
}
