using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Diamond : Figure
    {
        public double Side { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Diamond():this(0.0) { }
       
        public Diamond(double side)
        {
            Side = side;
            FigurePerimeter = 4 * side;
        }
        public override string ToString()
        {
            return $"This is a diamond with sides: {Side}.\n" + base.ToString();
        }
    }
}
