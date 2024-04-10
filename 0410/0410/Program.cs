using A;
Date d1 = new Date(1, 1, 2000);
Date d2 = new Date("10/04/2024"); // "<zi>/<luna>/<an>"
Date d3 = new Date("16-12-1989"); // "<zi>-<luna>-<an>"

//Console.WriteLine(d1);
//Console.WriteLine(d2);
//Console.WriteLine(d3);

List<Date> dates = new List<Date>();

dates.Add(d1);
dates.Add(d2);
dates.Add(d3);
dates.Sort();

foreach (Date date in dates)
    Console.WriteLine(date);

Date d4;
try
{
	d4 = new Date("40-12-2025");
}
catch (Exception e)
{
    Console.WriteLine(e.Message);
}



Console.WriteLine();
