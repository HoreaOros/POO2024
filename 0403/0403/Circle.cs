using System.Reflection.Metadata.Ecma335;

internal class Circle
{
    // fields
    private Point p;
    private int radius;


    // ctors
    public Circle(Point p, int radius)
    {
        this.p = p;
        this.radius = radius;
    }

    // properties
    public int Radius => radius;
    public Point Point => p;
    // methods
    public override string ToString()
    {
        return $"[Center: {p}, Radius: {radius}]";
    }

    public double Area()
    {
        return Math.PI * Math.Pow(radius, 2);
    }
    public double Perimeter() // lungimea cercului/circumferinta
    {
        return 2 * Math.PI * radius;
    }
}