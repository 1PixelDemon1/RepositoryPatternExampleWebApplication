using GameStore.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameStore.Infrastructure.Data
{
    public class GameStoreDbContext : DbContext
    {

        public DbSet<Game> Games { get; set; }
        public DbSet<GamePublisher> GamePublishers { get; set; }

        public GameStoreDbContext() {}
        public GameStoreDbContext(DbContextOptions<GameStoreDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // This code is unnecessary as EF automatically binds two tables
            // but explicity is much better.
            modelBuilder.Entity<Game>()
                .HasOne(game => game.Publisher)
                .WithMany(pub => pub.Games)
                .HasForeignKey("PublisherId");

            modelBuilder.Entity<GamePublisher>()
                .HasOne(pub => pub.MotherCompany)
                .WithMany()
                .HasForeignKey("MotherCompanyId");

            base.OnModelCreating(modelBuilder);
        }
    }
}
