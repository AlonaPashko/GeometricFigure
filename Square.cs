using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Square : Figure
    {
        private double sideA;
        
        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Square(): this(0.0) { }
       
        public Square(double sideA)
        {
            this.sideA = sideA;
        }

        public override string ToString()
        {
            return $"This is a square with side: {sideA}.\n" + base.ToString();
        }

    }
}
