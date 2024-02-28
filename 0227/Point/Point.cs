// See https://aka.ms/new-console-template for more information


internal class Point
{
    float x, y;


    //public Point(): this(0, 0)
    //{
    //    //this.x = 0;
    //    //this.y = 0;
    //}

    public Point(float x = 0, float y = 0)
    {
        this.x = x;
        this.y = y;
    }

    public override string ToString()
    {
        return $"[{x}, {y}]";
    }

    public float EuclideanDistanceTo(Point other)
    {
        if (other == null)
            throw new ArgumentException();

        return (float)Math.Sqrt(Math.Pow(this.x - other.x, 2) +
                Math.Pow(this.y - other.y, 2));
    }
}