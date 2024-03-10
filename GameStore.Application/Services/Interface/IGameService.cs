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
    public interface IGameService
    {
        IEnumerable<Game> GetAllGames();
        Game GetGameById(int id);
        void UpdateGame(Game game);
        void RemoveGame(int id);
        void AddGame(Game game);
        void SeedGames();
    }
}
