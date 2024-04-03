
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


List<Shape> shapes = new List<Shape>();
shapes.Add(new Circle(p, 10));
shapes.Add(new Rectangle());
shapes.Add(new Circle(new Point(), 5));
shapes.Add(new Rectangle(new Point(2, 3), 7, 8));


//// O solutie posibila pentru a calcula aria totala a formelor geometrice
//double totalArea = 0;
//foreach (var item in shapes)
//{
//    if (item is Circle)
//        totalArea += ((Circle)item).Area();
//    else if (item is Rectangle)
//        totalArea += ((Rectangle)item).Area();
//}

double totalArea = 0;
foreach (Shape shape in shapes)
    totalArea += shape.Area();


