using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Trapezoid : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double SideD { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Trapezoid():this (0.0, 0.0, 0.0, 0.0) { }
        
        public Trapezoid(double sideA, double sideB, double sideC, double sideD)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            SideD = sideD;
            FigurePerimeter = SideA + SideB + SideC + SideD;
        }
        public override string ToString()
        {
            return $"This is a trapezoid with sides: {SideA}, {SideB}, {SideC}, {SideD}.\n" + base.ToString();
        }
    }
}
