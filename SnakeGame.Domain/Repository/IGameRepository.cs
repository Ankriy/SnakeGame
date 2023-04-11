
using SnakeGame.Domain.Models.Games;

namespace SnakeGame.Domain.Repository
{
    public interface IGameRepository : IRepository<Game>
    {
        ICollection<Game> Get();
    }
}
