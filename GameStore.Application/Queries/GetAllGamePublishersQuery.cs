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
    public class GetAllGamePublishersQuery : BaseQuery<IEnumerable<GamePublisher>>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllGamePublishersQuery(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override IEnumerable<GamePublisher> Execute()
        {
            var gamePublishers = _unitOfWork.GamePublishers.GetAll();
            if (gamePublishers == null)
            {
                throw new ApplicationException("No publishers found");
            }
            return gamePublishers;
        }

        public override void Validate() {}
    }
}
