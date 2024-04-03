public class Circle: Shape
{
    // fields
    
    private int radius;


    // ctors
    public Circle(Point p, int radius): base(p)
    {
        this.radius = radius;
    }

    // properties
    public int Radius => radius;
    // methods
    public override string ToString()
    {
        return $"[Center: {Point}, Radius: {radius}]";
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