using GameStore.Application.Repository;
using GameStore.Domain.Entities;
using GameStore.Infrastructure.Data;
using GameStore.Infrastructure.EFCoreRepository;
using GameStore.Infrastructure.RemoteRepository;
using GameStore.Infrastructure.RemoteRepository.HttpHandler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly GameStoreDbContext _dbContext;

        public IRepository<Game> Games { get; set; }
        public IRepository<GamePublisher> GamePublishers { get; set; }


        public UnitOfWork(GameStoreDbContext dbContext, IHttpHandler httpHandler)
        {
            _dbContext = dbContext;
            Games = new Repository<Game>(_dbContext);
            GamePublishers = new GamePublisherRemoteRepository(httpHandler);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
