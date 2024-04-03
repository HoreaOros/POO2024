internal class Point
{
    // fields
    private int x;
    private int y;


    // constructor
    public Point(int x, int y)
    {
        this.x = x;
        this.y = y;
    }
    public Point() : this(0, 0)
    {
    }

    // methods
    public override string ToString()
    {
        return $"({x}, {y})";
    }

    // properties
    //public int X
    //{
    //    get
    //    {
    //        return x;
    //    }
    //}
    //public int Y 
    //{ 
    //    get 
    //    { 
    //        return y; 
    //    } 
    //}

    public int X => x;
    public int Y => y;

}