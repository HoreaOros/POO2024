// See https://aka.ms/new-console-template for more information


Console.WriteLine("Hello, World!");
Point p = new Point();
Console.WriteLine(p);

Point p2 = new Point(3,4);
Console.WriteLine(p2);

Console.WriteLine($"Euclidean distance from {p} to {p2} is {p.EuclideanDistanceTo(p2)}");
