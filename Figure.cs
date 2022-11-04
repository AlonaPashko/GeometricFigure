using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    abstract class Figure
    {
        public double FigureArea { get; set; }

        public double FigurePerimeter { get; set; }

        public Figure() : this(0.0, 0.0) { }
        
        public Figure(double area, double perimeter) 
        {
            FigureArea = area;
            FigurePerimeter = perimeter;
        }

        public override string ToString()
        {
            return "Figure area: " + FigureArea.ToString() +
                "\nFigure perimeter: " + FigurePerimeter.ToString();
        }

    }
}
