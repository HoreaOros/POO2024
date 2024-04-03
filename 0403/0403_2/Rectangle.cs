internal class Rectangle: Shape
{
    // fields
    private int width;
    private int height;


    // c-tor
    public Rectangle(Point p, int width, int height)
    {
        this.Point = p;
        this.width = width;
        this.height = height;
    }

    // properties
    //public int Width
    //{
    //    get
    //    {
    //        return width;
    //    }
    //}
    //public int Height
    //{
    //    get
    //    {
    //        return height;
    //    }
    //}
    public int Width => width;
    public int Height => height;

    // methods
    public override string ToString()
    {
        return $"[Origin: {Point}, Width = {Width}, Height = {Height}]";
    }

    public override double Area()
    {
        return Width * Height;
    }
    public override double Perimeter() // lungimea cercului
    {
        return 2 * (Width + Height);
    }
}