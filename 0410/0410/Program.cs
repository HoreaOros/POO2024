Date d1 = new Date(1, 1, 2000);
Date d2 = new Date("10/04/2024"); // "<zi>/<luna>/<an>"
Date d3 = new Date("10-04-2024"); // "<zi>-<luna>-<an>"

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