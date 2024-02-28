using System.Runtime.CompilerServices;

internal class Rational
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
    }
}