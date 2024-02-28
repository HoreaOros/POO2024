using System.Runtime.CompilerServices;

internal class Rational: IEquatable<Rational>
{
    private int numarator;
    private int numitor;

    public Rational(): this(0,1)
    {
    }

    public Rational(int numarator): this(numarator, 1)
    {
    }

    public Rational(string str)
    {
        string[] token = str.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
        if (token.Length < 1 || token.Length > 2)
            throw new ArgumentException("Numar rational invalid");

        if(token.Length == 1)
        {
            bool r = int.TryParse(token[0], out numitor);
            if (r == false)
                throw new ArgumentException("Numaratorul nu este un numar valid");
        }
        else if(token.Length == 2)
        {
            bool r1 = int.TryParse(token[0], out numitor);
            bool r2 = int.TryParse(token[1], out numarator);
            if (r1 == false || r2 == false)
                throw new ArgumentException("Numarul Rational nu este valid");
        }
    }

    public Rational(int numarator, int numitor)
    {
        this.numarator = numarator;
        this.numitor = numitor;
        Ireductibil();
    }

    public void Ireductibil()
    {
        int r = Util.gcd(numarator, numitor);
        numarator /= r;
        numitor /= r;
    }

    public Rational Add(Rational other)
    {
        Rational r = new Rational();
        r.numitor = this.numitor * other.numitor;
        r.numarator = this.numarator * other.numitor + this.numitor * other.numarator;
        r.Ireductibil();
        return r;
    }

    public Rational Power(int e)
    {
        Rational r = new Rational();
        r.numarator = (int)Math.Pow(this.numarator, e);
        r.numitor = (int)Math.Pow(this.numitor, e);
        r.Ireductibil();
        return r;
    }

    public static Rational operator+(Rational a, Rational b)
    {
        return a.Add(b);
    }
    
    public static Rational operator ^(Rational a, int e)
    {
        return a.Power(e);
    }

    public override bool Equals(object? obj)
    {
        return this.Equals(obj as Rational);
    }

    public bool Equals(Rational? other)
    {
        if (other is null)
        {
            return false;
        }

        // Optimization for a common success case.
        if (Object.ReferenceEquals(this, other))
        {
            return true;
        }

        // If run-time types are not exactly the same, return false.
        if (this.GetType() != other.GetType())
        {
            return false;
        }

        return this.numarator * other.numitor == this.numitor * other.numarator;
    }
    public override int GetHashCode()
    {
        return (numarator, numitor).GetHashCode();
    }

    public static bool operator ==(Rational lhs, Rational rhs)
    {
        if (lhs is null)
        {
            if (rhs is null)
            {
                return true;
            }

            // Only the left side is null.
            return false;
        }
        // Equals handles case of null on right side.
        return lhs.Equals(rhs);
    }
    public static bool operator !=(Rational lhs, Rational rhs) => !(lhs == rhs);
}