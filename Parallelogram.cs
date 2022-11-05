using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Parallelogram : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double HeightA { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Parallelogram():this (0.0, 0.0, 0.0){}
        
        public Parallelogram(double sideA, double sideB, double heightA)
        {
            SideA = sideA;
            SideB = sideB;
            HeightA = heightA;
            FigurePerimeter = 2 * (SideA + SideB);
            FigureArea = SideA * HeightA;
        }
        public override string ToString()
        {
            return $"This is a parallelogram with sides: {SideA}, {SideB} and height - {HeightA}.\n" 
                + base.ToString();
        }
    }
}
