
Point p = new Point(3, 4);
Console.WriteLine(p);

Circle c = new Circle(p, 10);
Console.WriteLine(c);

Console.WriteLine($"Circumferinta cercului {c} este {c.Perimeter()}");
Console.WriteLine($"Aria cercului {c} este {c.Area()}");

Rectangle r = new Rectangle {Point = p, Width = 4, Height = 8 };
Console.WriteLine(r);
Console.WriteLine($"Perimetrul dreptunghiului {r} este {r.Perimeter()}");
Console.WriteLine($"Aria dreptunghiului {r} este {r.Area()}");