using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using SnakeGame.Domain.Models.Games;

namespace SnakeGame.DAL.EF
{
    public class PostgreeContext : DbContext
    {
        public PostgreeContext(DbContextOptions<PostgreeContext> options)
            : base(options)
        {
        }
        public DbSet<Game> Games => Set<Game>();
    }
}