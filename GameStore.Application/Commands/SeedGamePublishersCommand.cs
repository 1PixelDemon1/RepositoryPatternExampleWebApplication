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
    public class SeedGamePublishersCommand : BaseCommand
    {
        private readonly IUnitOfWork _unitOfWork;

        public SeedGamePublishersCommand(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public override void Execute()
        {
            _unitOfWork.GamePublishers.Add(new GamePublisher("Rockstar Games", null, null, false));
            _unitOfWork.GamePublishers.Add(new GamePublisher("Toby Fox", null, null, true));
            _unitOfWork.GamePublishers.Add(new GamePublisher("Mojang", null, null, false));
            _unitOfWork.SaveChanges();
        }

        public override void Validate() {}
    }
}
