using System.Net.Http.Headers;
using Util;
internal class DateComparerDescending : IComparer<Date>
{
    public int Compare(Date? x, Date? y)
    {
        if(x == null)
            return 1;
        return -x.CompareTo(y);
    }
}
internal class Date: IComparable<Date>
{
    #region Fields
    private int zi;
    private int luna;
    private int an;
    public static readonly DateComparerDescending DESC = new DateComparerDescending();
    #endregion

    #region Constructors
    public Date(int zi, int luna, int an)
    {
        Validate(zi, luna, an);
        this.zi = zi;
        this.luna = luna;
        this.an = an;
    }

    public Date(string str)
    {
        string[] tokens = str.Split(new char[] { '/', '-' }, 
            StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        if (tokens.Length != 3)
            throw new ArgumentException("Data este invalida");

        this.zi = int.Parse(tokens[0]);
        this.luna = int.Parse(tokens[1]);
        this.an = int.Parse(tokens[2]);

    }

    #endregion

    #region Methods
    private void Validate(int zi, int luna, int an)
    {
        if (an < 0 || an > 9999)
            throw new ArgumentException("Anul este invalid");
        if (luna < 1 || luna > 12)
            throw new ArgumentException("Luna este invalida");
        var dict = new Dictionary<int, int>
        {
            [1] = 31,
            [2] = 28,
            [3] = 31,
            [4] = 30,
            [5] = 31,
            [6] = 30,
            [7] = 31,
            [8] = 31,
            [9] = 30,
            [10] = 31,
            [11] = 30,
            [12] = 31,
        };
        if ((an % 4 == 0 && an % 100 != 0) || (an % 400 == 0))
            dict[2]++;
        if (zi < 1 || zi > dict[luna])
            throw new ArgumentException("Ziua nu este valida");
    }
    public override string ToString()
    {
        //return $"{zi}-{luna,2:00}-{an}";
        return $"{zi} {luna.ToMonthName()} {an}";
    }

    public int CompareTo(Date? other)
    {
        if (other == null)
            return 1;
        if (this.an < other.an) return -1;
        if (this.an > other.an) return 1;
        if (this.luna < other.luna) return -1;
        if (this.luna > other.luna) return 1;
        if (this.zi < other.zi) return -1;
        if (this.zi > other.zi) return 1;
        return 0;
    }

    public override bool Equals(object? obj)
    {
        if (obj == this)
            return true;

        if (obj == null)
            return false;

        if (obj.GetType() != this.GetType())
            return false;

        Date that = (Date)obj;
        return (this.an == that.an && this.luna == that.luna && this.zi == that.zi);
    }
    public override int GetHashCode()
    {
        //int hash = 17;
        //hash = 31 * hash + luna;
        //hash = 31 * hash + zi;
        //hash = 31 * hash + an;
        //return hash;

        return HashCode.Combine(an, luna, zi);
    }

    
    #endregion
}