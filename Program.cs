
using GeometricFigure;

Circle circle1 = new Circle(8);
Console.WriteLine(circle1);
Console.WriteLine("----------------------------");

Diamond diamond1 = new Diamond(3, 5);
Console.WriteLine(diamond1);
Console.WriteLine("----------------------------");

Ellipse ellipse1 = new Ellipse(5, 2);
Console.WriteLine(ellipse1);
Console.WriteLine("----------------------------");

Parallelogram parallelogram1 = new Parallelogram(4, 7, 5);
Console.WriteLine(parallelogram1);
Console.WriteLine("----------------------------");

Rectangle rectangle1 = new Rectangle(5, 9);
Console.WriteLine(rectangle1);
Console.WriteLine("----------------------------");

Square square1 = new Square(2);
Console.WriteLine(square1);
Console.WriteLine("----------------------------"); 

Trapezoid trapezoid1 = new Trapezoid(8, 4, 5, 7);
Console.WriteLine(trapezoid1);
Console.WriteLine(trapezoid1.PrintSidesLength());
Console.WriteLine("----------------------------");

Triangle triangle1 = new Triangle(5, 7, 6, 5);
Console.WriteLine(triangle1);
Console.WriteLine(triangle1.PrintSidesLength());
Console.WriteLine("----------------------------");

ComposedFigure composedFigure1 = new ComposedFigure();
composedFigure1.Figures.Add(square1);
composedFigure1.Figures.Add(triangle1);
composedFigure1.Figures.Add(trapezoid1);
composedFigure1.Figures.Add(rectangle1);
composedFigure1.CountArea();
Console.WriteLine(composedFigure1);










