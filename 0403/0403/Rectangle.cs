public class Rectangle: Shape
{
    // properties
    public int Width{ get; init; }
    public int Height { get; init; }


    // methods
    public override string ToString()
    {
        return $"[Origin: {Point}, Width = {Width}, Height = {Height}]";
    }

    // ctor
    public Rectangle(Point p, int width, int height): base(p)
    {
        Width = width;
        Height = height;
    }
    public Rectangle()
    {
    }
    public override double Area()
    {
        return Width * Height;
    }
    public override double Perimeter() 
    {
        return 2 * (Width + Height);
    }
}