Point p = new Point(2, 3);
Console.WriteLine(p);

Circle c = new Circle(p, 5);
Circle c2 = new Circle { Point = new Point(4, 5), Radius = 10 };
Console.WriteLine(c);
Console.WriteLine($"Aria cercului este: {c.Area()}");
Console.WriteLine($"Lungimea cercului este: {c.Perimeter()}");

Rectangle r = new Rectangle(p, 5, 6);
Console.WriteLine(r);


List<Shape> shapes = new List<Shape>();
shapes.Add(c);
shapes.Add(r);
shapes.Add(c2);

foreach (Shape shape in shapes)
    Console.WriteLine(shape);

double totalArea = 0;
foreach (Shape item in shapes)
    totalArea += item.Area(); 

//foreach (Shape item in shapes)
//    if(item is Circle)
//    {
//        Circle c3 = (Circle)item;
//    }
