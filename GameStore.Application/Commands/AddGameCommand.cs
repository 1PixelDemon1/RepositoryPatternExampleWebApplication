using GameStore.Application.Commands.Interface;
using GameStore.Application.Repository;
using GameStore.Domain.Entities;

namespace GameStore.Application.Commands
{
    public class AddGameCommand : BaseCommand
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly Game _game;

        public AddGameCommand(IUnitOfWork unitOfWork, Game game)
        {
            _unitOfWork = unitOfWork;
            _game = game;
        }

        public override void Execute()
        {
            _unitOfWork.Games.Add(_game);
            _unitOfWork.SaveChanges();
        }

        public override void Validate()
        {
            _game.Validate();
        }
    }
}
