using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Diamond : Figure
    {
        private double sideA;

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Diamond():this(0.0) { }
       
        public Diamond(double sideA)
        {
            this.sideA = sideA;
        }
        public override string ToString()
        {
            return $"This is a diamond with side: {sideA}.\n" + base.ToString();
        }
    }
}
