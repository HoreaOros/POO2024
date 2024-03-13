// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;
using System.Text;

internal class MyDateTime : IEquatable<MyDateTime>, IComparable<MyDateTime>
{
    private int zi;
    private int luna;
    private int an;
    private int ora;
    private int minut;
    private int secunda;

    public MyDateTime(int zi = 0, int luna = 0, int an = 0, int ora = 0, int minut = 0, int secunda = 0)
    {
        if (isValid(zi, luna, an, ora, minut, secunda))
        {
            this.zi = zi;
            this.luna = luna;
            this.an = an;
            this.ora = ora;
            this.minut = minut;
            this.secunda = secunda;
        }
        else
            throw new ArgumentException("Invalid date");
    }

    private bool isValid(int zi, int luna, int an, int ora, int minut, int secunda)
    {
        if (ora < 0 || ora > 23)
            return false;
        if (minut < 0 || minut > 59)
            return false;
        if (secunda < 0 || secunda > 59)
            return false;
        if (an < 0)
            return false;
        if (luna < 1 || luna > 12)
            return false;

        int[] zile = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };

        if (zi < 1)
            return false;
        if (luna == 2)
            if (IsLeapYear(an))
            {
                if (zi > zile[luna - 1] + 1)
                    return false;
            }
            else
            {
                if (zi > zile[luna - 1])
                    return false;
            }
        else
            if (zi > zile[luna - 1])
            return false;

        return true;
    }

    public bool IsLeapYear(int an)
    {
        return ((an % 4 == 0) && (an % 100 != 0)) || (an % 400 == 0);
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append(this.zi)
          .Append(".")
          .Append(string.Format("{0,2:D2}", this.luna))
          .Append(".")
          .Append(this.an)
          .Append(" ")
          .Append(this.ora)
          .Append(":")
          .Append(this.minut)
          .Append(":")
          .Append(this.secunda);
        return sb.ToString();
    }

    public bool Equals(MyDateTime? other)
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

        // Return true if the fields match.
        // Note that the base class is not invoked because it is
        // System.Object, which defines Equals as reference equality.
        return this.an == other.an && this.luna == other.luna && this.zi == other.zi
            && this.ora == other.ora && this.minut == other.minut && this.secunda == other.secunda;
    }

    public int Zi => zi;
    public int Luna
    {
        get
        {
            return luna;
        }
    }
    public int An => an;
    public int Ora => ora;
    public int Minut => minut;
    public int Secunda => secunda;



    public static bool operator ==(MyDateTime lhs, MyDateTime rhs)
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
    public static bool operator !=(MyDateTime d1, MyDateTime d2)
    {
        return !(d1 == d2);
    }

    public override bool Equals(object? obj)
    {
        return this.Equals(obj as MyDateTime);
    }
    public override int GetHashCode() => (zi, luna, an, ora, minut, secunda).GetHashCode();


    /// <summary>
    /// TODO
    /// </summary>
    /// <param name="other"></param>
    /// <returns></returns>
    /// <exception cref="NotImplementedException"></exception>
    public int CompareTo(MyDateTime? other)
    {
        throw new NotImplementedException();
    }

    public static bool operator <(MyDateTime? lhs, MyDateTime? rhs)
    {
        throw new NotImplementedException();

    }
    public static bool operator <=(MyDateTime? lhs, MyDateTime? rhs)
    {
        throw new NotImplementedException();

    }
    public static bool operator >(MyDateTime? lhs, MyDateTime? rhs)
    {
        throw new NotImplementedException();

    }
    public static bool operator >=(MyDateTime? lhs, MyDateTime? rhs)
    {
        throw new NotImplementedException();

    }
    /// <summary>
    /// Diferenta dintre doua date calendaristice (in zile)
    /// </summary>
    /// <param name="d1"></param>
    /// <param name="d2"></param>
    /// <returns></returns>
    public static int operator -(MyDateTime d1, MyDateTime d2)
    {
        // TODO
        // 
        int result = 0;
        while (d1 != d2)
        {
            result++;
            // din data mai mare scad o zi
        }
        return result;

    }
}