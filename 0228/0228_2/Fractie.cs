using System.Collections.Specialized;
using System.Reflection.Metadata;

internal class Fractie : IEquatable<Fractie>
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
        Ireductibil();
    }

    private void Ireductibil()
    {
        int r = Util.gcd(this.numarator, this.numitor);
        this.numarator /= r;
        this.numitor /= r;
    }

    public Fractie(string str)
    {
        string[] tokens = str.Split(new char[] {'/'}, StringSplitOptions.RemoveEmptyEntries);
        if (tokens.Length < 1 || tokens.Length > 2)
            throw new ArgumentException("Fractie invalida");

        if(tokens.Length == 1)
        {
            bool r = int.TryParse(tokens[0], out numarator);
            if (r == false)
                throw new ArgumentException("Numar incorect");
            numitor = 1;
        }
        else
        {
            bool r1 = int.TryParse(tokens[0], out numarator);
            bool r2 = int.TryParse(tokens[1], out numitor);
            if (r1 == false || r2 == false)
                throw new ArgumentException("Numar incorect");
        }
        Ireductibil();
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

    public Fractie Power(int e)
    {
        Fractie f = new Fractie();
        f.numarator = (int)Math.Pow(this.numarator, e);
        f.numitor = (int)Math.Pow(this.numitor, e);
        return f;
    }

    public static Fractie operator^(Fractie lhs, int e)
    {
        return lhs.Power(e);
    }
    public static Fractie operator+(Fractie lhs, Fractie rhs)
    {
        return lhs.Add(rhs);
    }


    public override bool Equals(object? obj)
    {
        return this.Equals(obj as Fractie);
    }

    public bool Equals(Fractie? p)
    {
        if (p is null)
        {
            return false;
        }

        // Optimization for a common success case.
        if (Object.ReferenceEquals(this, p))
        {
            return true;
        }

        // If run-time types are not exactly the same, return false.
        if (this.GetType() != p.GetType())
        {
            return false;
        }

        return this.numarator * p.numitor == this.numitor * p.numarator;
    }

    public override int GetHashCode()
    {
        return (this.numarator, this.numitor).GetHashCode();
    }
    public static bool operator ==(Fractie lhs, Fractie rhs)
    {
        if (lhs is null)
        {
            if (rhs is null)
            {
                // null == null = true.
                return true;
            }

            // Only the left side is null.
            return false;
        }
        // Equals handles the case of null on right side.
        return lhs.Equals(rhs);
    }
    public static bool operator !=(Fractie lhs, Fractie rhs) => !(lhs == rhs);

    public static bool operator <(Fractie lhs, Fractie rhs)
    {
        return lhs.numarator * rhs.numitor < lhs.numitor * rhs.numarator;
    }
    public static bool operator >(Fractie lhs, Fractie rhs)
    {
        return lhs.numarator * lhs.numitor > lhs.numitor * rhs.numarator;
    }
    public static bool operator <=(Fractie lhs, Fractie rhs)
    {
        return lhs < rhs || lhs == rhs;
    }
    public static bool operator >=(Fractie lhs, Fractie rhs)
    {
        return lhs > rhs || lhs == rhs;
    }
}


