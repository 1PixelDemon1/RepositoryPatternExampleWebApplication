using GameStore.Domain.Entities;

namespace GameStore.Application.Repository
{
    public interface IUnitOfWork
    {
        public IRepository<Game> Games { get; set; }
        public IRepository<GamePublisher> GamePublishers { get; set; }
        void SaveChanges();
    }
}
