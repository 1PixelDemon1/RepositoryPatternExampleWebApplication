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
using System.Xml.Serialization;

namespace GameStore.Application.Services
{
    public class GameService : IGameService
    {
        private readonly IUnitOfWork _unitOfWork;

        public GameService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public IEnumerable<Game> GetAllGames()
        {
            return new GetAllGamesQuery(_unitOfWork).Handle();
        }

        public Game GetGameById(int id)
        {
            return new GetGameByIdQuery(_unitOfWork, id).Handle();
        }

        public void UpdateGame(Game game)
        {
            new UpdateGameCommand(_unitOfWork, game).Handle();
        }

        public void RemoveGame(int id)
        {
            new RemoveGameCommand(_unitOfWork, id).Handle();
        }

        public void AddGame(Game game)
        {
            new AddGameCommand(_unitOfWork, game).Handle();
        }

        public void SeedGames()
        {
            new SeedGamesCommand(_unitOfWork).Handle();
        }
    }
}
