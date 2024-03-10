using GameStore.Application.Repository;
using GameStore.Domain.Entities;
using GameStore.Infrastructure.Data;
using GameStore.Infrastructure.EFCoreRepository;
using GameStore.Infrastructure.InMemoryRepository;
using GameStore.Infrastructure.InMemoryRepository.InMemoryStorage.Interface;
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


        public UnitOfWork(GameStoreDbContext dbContext, IInMemoryStorage<GamePublisher> gamePublisherStorage)
        {
            _dbContext = dbContext;
            Games = new Repository<Game>(_dbContext);
            GamePublishers = new InMemoryGamePublisherRepository(gamePublisherStorage);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
