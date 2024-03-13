using System.Globalization;

DateTime dt = DateTime.Now;
Console.WriteLine(dt);

DateTimeOffset dt2 = DateTimeOffset.Now;
Console.WriteLine(dt2);

DateTime dt3 = new DateTime(125487515558445855, DateTimeKind.Local);
Console.WriteLine(dt3);


DateTime dt4 = new DateTime(5500, 5, 22, new HebrewCalendar());
Console.WriteLine(dt4);

Console.WriteLine(DateTime.MinValue);
Console.WriteLine(DateTime.MaxValue);

Console.WriteLine(dt.Year);
Console.WriteLine(dt.Hour);
Console.WriteLine(dt.DayOfWeek);
Console.WriteLine(dt.DayOfYear);



MyDateTime mdt = new MyDateTime();
