using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    abstract class Figure
    {
        public abstract double FigureArea { get; set; }
        public abstract double FigurePerimeter { get; set; }

        public override string ToString()
        {
            return "Figure area: " + Math.Round(FigureArea, 3).ToString() +
                "\nFigure perimeter: " + Math.Round(FigurePerimeter, 3).ToString();
        }

    }
}
