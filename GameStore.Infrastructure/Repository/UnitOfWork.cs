using GameStore.Application.Repository;
using GameStore.Domain.Entities;
using GameStore.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.Repository
{
    public class UnitOfWork : IUnitOfWork
    {
        public IRepository<Game> Games { get; set; }
        public IRepository<GamePublisher> GamePublishers { get; set; }

        private readonly GameStoreDbContext _dbContext;

        public UnitOfWork(GameStoreDbContext dbContext)
        {
            _dbContext = dbContext;
            Games = new Repository<Game>(_dbContext);
            GamePublishers = new Repository<GamePublisher>(_dbContext);
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }
    }
}
