using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Rectangle : Figure
    {
        private double sideA;
        private double sideB;
        
        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Rectangle() : this(0.0, 0.0) { }
        
        public Rectangle(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
        }
        public override string ToString()
        {
            return $"This is a rectangle with sides: {sideA}, {sideB}.\n" + base.ToString();
        }
    }
}
