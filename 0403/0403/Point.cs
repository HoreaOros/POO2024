internal class Point
{
    // fields
    private int x;
    private int y;


    // constructors
    public Point(): this(0, 0)
    { 
    }
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }

    // properties
    public int X
    {
        get
        {
            return x;
        }
    }

    public int Y => y;
    // methods
    public override string ToString()
    {
        return $"({x}, {y})";
    }

}