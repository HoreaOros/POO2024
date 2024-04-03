internal class Circle : Shape
{

    #region Properties
    public int Radius { get; init; }
    #endregion

    #region Constructors
    public Circle(Point p, int radius)
    {
        this.Point = p;
        this.Radius = radius;
    }
    public Circle()
    { 
    }
    #endregion

    #region Methods
    public override string ToString()
    {
        return $"[Origin: {Point}, Radius = {Radius}]";
    }

    public override double Area()
    {
        return Math.PI * Math.Pow(Radius, 2);
    }
    public override double Perimeter() // lungimea cercului
    {
        return 2 * Math.PI * Radius;
    }
    #endregion
}