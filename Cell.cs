namespace GameOfLife
{
    public class Cell
    {
        public bool IsAlive { get; set; }
        public int NeighborsNumber { get; set; }

        public void Toggle()
        {
            IsAlive = !IsAlive;
        }
    }
}
