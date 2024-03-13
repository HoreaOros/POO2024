using System.Globalization;

// ***********************************************
// 1.  DateTime - demo
DateTime dt = DateTime.Now;
Console.WriteLine(dt.Ticks);
Console.WriteLine(dt);

DateTimeOffset dt2 = DateTimeOffset.Now;
Console.WriteLine(dt2);

DateTime dt3 = new DateTime(1254875155584458555, DateTimeKind.Local);
Console.WriteLine(dt3);


DateTime dt4 = new DateTime(5500, 5, 22, new HebrewCalendar());
Console.WriteLine(dt4);

Console.WriteLine(DateTime.MinValue);
Console.WriteLine(DateTime.MaxValue);

Console.WriteLine(dt.Year);
Console.WriteLine(dt.Hour);

Console.WriteLine(dt.DayOfWeek);
Console.WriteLine(dt.DayOfYear);
// ***********************************************




// ***********************************************
// ***********************************************
// 2. MyDateTime - demo
MyDateTime md = new MyDateTime(12, 3, 2024, 9, 18, 42);
Console.WriteLine(md);

MyDateTime md2 = new MyDateTime(23, 6, 2023);
MyDateTime md3 = new MyDateTime(an: 2025, luna: 12, zi: 13);
Console.WriteLine(md3);

if (md2 == md3)
{
    Console.WriteLine($"{md2} / {md3} sunt egale");
}
else
{
    Console.WriteLine($"{md2} / {md3} nu sunt egale");
}

Console.WriteLine(md2 - md3); // 


// ***********************************************