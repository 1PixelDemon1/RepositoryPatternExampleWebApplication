using GameStore.Domain.Entities;
using GameStore.Infrastructure.InMemoryRepository.InMemoryStorage.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.InMemoryRepository
{
    public class InMemoryGamePublisherRepository : InMemoryRepository<GamePublisher>
    {
        public InMemoryGamePublisherRepository(IInMemoryStorage<GamePublisher> storage) : base(storage){}

        public override void Add(GamePublisher value)
        {
            value.Id = _storage.Data.Count() + 1;
            _storage.Data.Add(value);
        }

        public override void Update(GamePublisher value)
        {
            var curValue = _storage.Data.FirstOrDefault(val => val.Id == value.Id);
            if(curValue != null)
            {
                _storage.Data.Remove(curValue);
                _storage.Data.Add(value);
            }
            else
            {
                throw new ApplicationException("Unable to find publisher.");
            }
        }
    }
}
