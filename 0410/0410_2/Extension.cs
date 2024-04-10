using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Util
{
    internal static class Extension
    {
        public static string ToMonthName(this int n) 
        {
            if (n < 1 || n > 12)
                throw new ArgumentException("Luna trebuie sa fie intre 1 si 12");
            var monthNames = new Dictionary<int, string>();
            monthNames.Add(1, "Ianuarie");
            monthNames.Add(2, "Februarie");
            monthNames.Add(3, "Martie");
            monthNames.Add(4, "Aprilie");
            monthNames.Add(5, "Mai");
            monthNames.Add(6, "Iunie");
            monthNames.Add(7, "Iulie");
            monthNames.Add(8, "August");
            monthNames.Add(9, "Septembrie");
            monthNames.Add(10, "Octombrie");
            monthNames.Add(11, "Noiembrie");
            monthNames.Add(12, "Decembrie");
            return monthNames[n];
        }
    }
}
