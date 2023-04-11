namespace SnakeGame.Models.Snakes
{
    public class SnakeCreateViewModel
    {
        public int Id { get; set; }
        public List<int[]> FirstGamer { get; set; }
        public List<int[]> SecondGamer { get; set; }
    }
}
