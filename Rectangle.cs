using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Rectangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Rectangle() : this(0.0, 0.0) { }
        
        public Rectangle(double sideA, double sideB)
        {
            SideA = sideA;
            SideB = sideB;
            FigurePerimeter = 2 * (SideA + SideB);
        }
        public override string ToString()
        {
            return $"This is a rectangle with sides: {SideA}, {SideB}.\n" + base.ToString();
        }
    }
}
