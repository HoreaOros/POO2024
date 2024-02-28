using System.Reflection.Metadata;

internal class Fractie
{
    private int numarator, numitor;

    // c-tor implicit (default)
    public Fractie(): this(0, 1)
    {
      
    }

    public Fractie(int numarator): this(numarator, 1)
    {
    }

    public Fractie(int numarator, int numitor)
    {
        this.numarator = numarator;
        this.numitor = numitor;
    }

    public override string ToString()
    {
        return $"({numarator} / {numitor})";
    }

    /// <summary>
    /// a/b + c / d = 
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    public Fractie Add(Fractie other)
    {
        Fractie r = new Fractie();
        r.numarator = this.numarator * other.numitor + this.numitor * other.numarator;
        r.numitor = this.numitor * other.numitor;
        return r;
    }
    public static Fractie operator+(Fractie lhs, Fractie rhs)
    {
        return lhs.Add(rhs);
    }
}