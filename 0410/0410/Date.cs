﻿using System.Net.Http.Headers;

internal class Date
{
    private int zi;
    private int luna;
    private int an;
    private bool anBisect = false;

    public Date(string str)
    {
        string[] tokens = str.Split(new char[] { '/', '-' });
        if (tokens.Length != 3)
            throw new ArgumentException("Sirul de caractere nu este o data valida");

        try
        {
            zi = int.Parse(tokens[0]);
            luna = int.Parse(tokens[1]);
            an = int.Parse(tokens[2]);
        }
        catch (FormatException e)
        {
            Console.WriteLine(e.Message);
        }
        catch(OverflowException e)
        {
            Console.WriteLine(e.Message);
        }
        catch (ArgumentNullException e) 
        {
            Console.WriteLine(e.Message);
        }
        ValiDate(zi, luna, an);
    }

    private void ValiDate(int zi, int luna, int an)
    {
        if (an < 0 || an > 9999)
            throw new ArgumentException("Invalid argument");


        if(luna < 1 || luna > 12)
            throw new ArgumentException("Invalid argument");
        var dict = new Dictionary<int, int>()
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
            [12] = 31
        };

        anBisect = (an % 4 == 0 && an % 100 != 0) || (an % 400 == 0);
        if (anBisect)
            dict[2]++;

        if(zi < 1 || zi > dict[luna])
            throw new ArgumentException("Invalid argument");

    }

    public Date(int zi, int luna, int an)
    {
        ValiDate(zi, luna, an);
        this.zi = zi;
        this.luna = luna;
        this.an = an;
    }
}