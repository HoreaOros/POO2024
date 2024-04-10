using Util;
internal class Date
{

    private int zi;
    private int luna;
    private int an;

    public Date(int zi, int luna, int an)
    {
        this.zi = zi;
        this.luna = luna;
        this.an = an;
    }
    public override string ToString()
    {
        //return $"{zi}-{luna,2:00}-{an}";
        return $"{zi} {luna.ToMonthName()} {an}";
    }
}