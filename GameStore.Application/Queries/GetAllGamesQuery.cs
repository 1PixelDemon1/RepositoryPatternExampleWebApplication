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
    public class GetAllGamesQuery : BaseQuery<IEnumerable<Game>>
    {

        private readonly IUnitOfWork _unitOfWork;
        public GetAllGamesQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override IEnumerable<Game> Execute()
        {
            var games = _unitOfWork.Games.GetAll();
            if(games == null)
            {
                throw new ApplicationException("No games found");
            }
            return games;
        }

        public override void Validate() {}
    }
}
