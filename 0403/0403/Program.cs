Point p = new Point(3, 4);
Console.WriteLine(p);

Circle c = new Circle(p, 10);
Console.WriteLine(c);

Console.WriteLine($"Circumferinta cercului {c} este {c.Perimeter()}");
Console.WriteLine($"Aria cercului {c} este {c.Area()}");