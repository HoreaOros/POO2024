Point p = new Point(2, 3);
Console.WriteLine(p);

Circle c = new Circle(p, 5);
Circle c2 = new Circle { Point = new Point(4, 5), Radius = 10 };
Console.WriteLine(c);
Console.WriteLine($"Aria cercului este: {c.Area()}");
Console.WriteLine($"Lungimea cercului este: {c.Perimeter()}");

Rectangle r = new Rectangle(p, 5, 6);