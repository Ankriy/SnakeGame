
using SnakeGame.Domain.Repository;
using SnakeGame.DAL.EF;
using SnakeGame.Domain.Models.Games;

namespace PocketSafe.DAL.EF.Repositories
{
    public class GameEFPostgreeRepository : IGameRepository, IRepository<Game>
    {

        private readonly PostgreeContext _context;

        public GameEFPostgreeRepository(PostgreeContext context)
        {
            _context = context;
        }


        public Game Create(Game item)
        {
            _context.Games.Add(item);
            _context.SaveChanges();
            return item;
        }

        public Game? Get(int id)
        {
            return _context.Games.FirstOrDefault(x => x.Id == id);
        }

        public ICollection<Game> Get()
        {
            throw new NotImplementedException();
        }
    }
}
