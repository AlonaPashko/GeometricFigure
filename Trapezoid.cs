using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Trapezoid : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;
        private double sideD;

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Trapezoid():this (0.0, 0.0, 0.0, 0.0) { }
        
        public Trapezoid(double sideA, double sideB, double sideC, double sideD)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
            this.sideD = sideD;
        }
        public override string ToString()
        {
            return $"This is a trapezoid with sides: {sideA}, {sideB}, {sideC}, {sideD}.\n" + base.ToString();
        }
    }
}
