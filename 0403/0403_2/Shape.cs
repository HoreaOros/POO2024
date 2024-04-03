internal abstract class Shape
{
    public Point? Point { get; init; }

    public abstract double Area();
    public abstract double Perimeter();
}