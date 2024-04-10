Date d1 = new Date(1, 10, 2000);
Console.WriteLine(d1);

try
{
	Date d2 = new Date(1, 13, 2025);
	Console.WriteLine(d2);
}
catch (ArgumentException e)
{
    Console.WriteLine(e.Message);
}


