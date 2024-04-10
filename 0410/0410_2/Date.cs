using System.Net.Http.Headers;
using Util;
internal class Date
{
    #region Fields
    private int zi;
    private int luna;
    private int an;
    #endregion

    #region Constructors
    public Date(int zi, int luna, int an)
    {
        Validate(zi, luna, an);
        this.zi = zi;
        this.luna = luna;
        this.an = an;
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
    #endregion
}