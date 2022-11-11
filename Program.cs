
using GeometricFigure;
using GeometricFigure.Exceptions;

//Circle circle1 = new Circle(7.7);
//Console.WriteLine(circle1);
//Console.WriteLine("----------------------------");

//Diamond diamond1 = new Diamond(3.3, 5.1);
//Console.WriteLine(diamond1);
//Console.WriteLine("----------------------------");

Ellipse ellipse1 = new Ellipse(1.4, 2.3);
Console.WriteLine(ellipse1);
Console.WriteLine("----------------------------");

//Parallelogram parallelogram1 = new Parallelogram(4.2, 6.7, 5.3);
//Console.WriteLine(parallelogram1);
//Console.WriteLine("----------------------------");

Rectangle rectangle1 = new Rectangle(5.18, 9.2);
Console.WriteLine(rectangle1);
Console.WriteLine("----------------------------");

Square square1 = new Square(2.35);
Console.WriteLine(square1);
Console.WriteLine("----------------------------");

Trapezoid trapezoid1 = new Trapezoid(8.1, 4.5, 5.3, 7.4);
Console.WriteLine(trapezoid1);
Console.WriteLine(trapezoid1.PrintSidesLength());
Console.WriteLine("----------------------------");


Triangle triangle1 = new Triangle(1.3, 2.5, 3.1, 5.5);
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










