

using _19_Rectangle;

Rectangle r1 = new Rectangle(2.0, 5.0);
Console.WriteLine(r1.Area());
Console.WriteLine(r1.Circumference());

r1.ResizeArea(2.0);
Console.WriteLine(r1.Area());

r1.ResizeSideLenght(0.1);
Console.WriteLine(r1.Area());

Rectangle hausAcker = new Rectangle(102.0, 50.8);
Console.WriteLine(hausAcker.Area());






