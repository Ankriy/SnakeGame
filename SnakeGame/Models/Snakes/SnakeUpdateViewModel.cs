namespace SnakeGame.Models.Snakes
{
    public class SnakeUpdateViewModel
    {
        public int Id { get; set; }
        public List<int[]> FirstGamer { get; set; }
        public List<int[]> SecondGamer { get; set; }
    }
}
