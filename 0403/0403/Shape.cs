public abstract class Shape
{
    // properties
    public Point Point { get; init; }

    // ctor
    public Shape(Point point)
    {
        this.Point = point;
    }
    public Shape() : this(new Point(0, 0))
    {
    }

}