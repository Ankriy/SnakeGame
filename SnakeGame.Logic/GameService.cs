using PocketSafe.Logic.Models.Games;
using SnakeGame.Domain.Models.Games;
using SnakeGame.Domain.Repository;

namespace SnakeGame.Logic
{
    public class GameService
    {
        private IGameRepository _gameRepository;

        public GameService(IGameRepository taskRepository)
        {
            _gameRepository = taskRepository;
        }

        public List<GameDTO> GetTestGamesList()
        {
            var tasks = _gameRepository.Get();
            var list = tasks.Select(x => new GameDTO()
            {
                Id = x.Id,
                Looser = x.Looser,
            }).ToList();
            return list;
        }

        public int AddGame(GameCreateDTO task)
        {
            var newGame = new Game()
            {
                Looser = task.Looser
            };
            _gameRepository.Create(newGame);
            return newGame.Id;
        }
        public GameDTO GetGame(int id)
        {
            var tasks = GetTestGamesList();
            var task = tasks.Where(u => u.Id == id).First();
            return new GameDTO()
            {
                Id = id,
                Looser = task.Looser,
            };
        }
        
    }
}