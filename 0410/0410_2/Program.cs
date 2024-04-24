Date d1 = new Date(1, 10, 2000);
Console.WriteLine(d1);


Date d2 = null; 
try
{
	d2 = new Date(1, 13, 2025);
	Console.WriteLine(d2);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}


Date d3 = new Date(" 12 / 08 / 2024 ");
Console.WriteLine(d3);
Date d4 = null; 
try
{
	d4 = new Date("ab/x8/2024");
	Console.WriteLine(d4);
}
catch (FormatException e)
{
    Console.WriteLine(e.Message);
}

Console.WriteLine(d4);



List<Date> dates = new List<Date>();

dates.Add(d1);
dates.Add(d3);
dates.Add(new Date(13, 7, 1970));

dates.Sort();
foreach (Date date in dates)
    Console.WriteLine(date);


dates.Sort(Date.DESC);
foreach (Date date in dates)
    Console.WriteLine(date);

Console.WriteLine("<end>");