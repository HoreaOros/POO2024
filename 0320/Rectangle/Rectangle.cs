
namespace Rectangle
{
    public class Rectangle : IPolygon
    {
        public Point Origin { get; private set; }
        public int Width { get; private set; }
        public int Height { get; private set; }
        public Rectangle(int x, int y, int width, int height)
        {
            Origin = new Point { X = x, Y = y }; Width = width; Height = height;
        }
        public Rectangle(Point p1, Point p2)
        {
            Origin = new Point(Math.Min(p1.X, p2.X), Math.Max(p1.Y, p2.Y));
            Width = Math.Abs(p1.X - p2.X);
            Height = Math.Abs(p1.Y - p2.Y);
        }
        public override string ToString()
        {
            return $"[{Origin.ToString()}, Width = {Width}, Height = {Height}]";
        }
        public int Perimeter()
        {
            return 2 * (Width + Height);
        }
        public int Area()
        {
            return Width * Height;
        }

        public bool IntersectsWith(Rectangle other)
        {
            Interval s1 = new Interval(this.Origin.X, this.Origin.X + this.Width);
            Interval s2 = new Interval(this.Origin.Y - this.Height, this.Origin.Y);

            Interval s1Other = new Interval(other.Origin.X, other.Origin.X + other.Width);
            Interval s2Other = new Interval(other.Origin.Y - other.Height, other.Origin.Y);

            Interval[] intervals = new Interval[] { s1, s2 };
            Array.Sort(intervals);
            return (s1.IntersectsWith(s1Other) && s2.IntersectsWith(s2Other));
        }
        /// <summary>
        /// Intersectia a doua dreptunghiuri
        /// </summary>
        /// <param name="other"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        public Rectangle? Intersect(Rectangle other)
        {
            if (!this.IntersectsWith(other))
                return null;

            throw new NotImplementedException();
        }
    }
}