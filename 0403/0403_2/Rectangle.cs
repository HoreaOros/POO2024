internal class Rectangle
{
    // fields
    private Point origin;
    private int width;
    private int height;


    // c-tor
    public Rectangle(Point p, int width, int height)
    {
        this.origin = p;
        this.width = width;
        this.height = height;
    }

    // properties
    public Point Point
    {
        get
        {
            return origin;
        }
    }
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
}