namespace Rectangle
{
    public class Point    {
        public int X { get; set; }
        public int Y { get; set; }
        public override string ToString()
        {
            return $"({X}, {Y})";
        }
        public Point(): this(0, 0)
        {
            
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }
    }
}