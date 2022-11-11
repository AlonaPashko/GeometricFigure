# GeometricFigure

As part of the educational task, an abstract class Figure with abstract properties Perimeter and Area was built. 

From it are inherited:

- class Circle,
- class Diamond,
- class Ellipse,
- class Parallelogram,
- class Rectangle,
- class Square,
- class Trapezoid,
- class Triangle.

The interface ISimplePolygon has been implemented for all classes except Ellipse and Circle.
ISimplePolygon has a properties:

- Height,
- Basis,
- Angle between the base and the adjacent side,
- Sides Amount,
- Sides Length,
- Polygon Area,
- Polygon Perimeter.

And a method for printing the sides length.

Implemented ComposedFigure class, which can consist of any number of polygons added to the list. 
A method for calculating the area of a figure - CountArea is defined for this class.

