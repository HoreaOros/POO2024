using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    public static class Extension
    {
        public static string ToMonthName(this int n)
        {
            if (n < 1 || n > 12)
                throw new ArgumentException("Argumentul trebuie sa fie intre 1 si 12");

            Dictionary<int, string> dict = new Dictionary<int, string>();
            dict.Add(1, "Ianuarie");
            dict.Add(2, "Februarie");
            dict.Add(3, "Martie");
            dict.Add(4, "Aprilie");
            dict.Add(5, "Mai");
            dict.Add(6, "Iunie");
            dict.Add(7, "Iulie");
            dict.Add(8, "August");
            dict.Add(9, "Septembrie");
            dict.Add(10, "Octombrie");
            dict.Add(11, "Noiembrie");
            dict.Add(12, "Decembrie");
            return dict[n];
        }
    }

}