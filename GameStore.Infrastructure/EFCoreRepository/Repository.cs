using GameStore.Application.Repository;
using GameStore.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.EFCoreRepository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly GameStoreDbContext _dbContext;
        private readonly DbSet<T> _dbSet;

        public Repository(GameStoreDbContext dbContext)
        {
            _dbContext = dbContext;
            _dbSet = dbContext.Set<T>();
        }

        public virtual void Add(T value)
        {
            _dbSet.Add(value);
        }

        public virtual IEnumerable<T>? GetAll()
        {
            return _dbSet;
        }

        public virtual void Remove(T value)
        {
            _dbSet.Remove(value);
        }

        public virtual void Update(T value)
        {
            _dbSet.Update(value);
        }
    }
}
