using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Square : Figure
    {
        public double Side { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Square(): this(0.0) { }
       
        public Square(double side)
        {
            Side = side;
            FigurePerimeter = 4 * Side;
        }

        public override string ToString()
        {
            return $"This is a square with side: {Side}.\n" + base.ToString();
        }

    }
}
