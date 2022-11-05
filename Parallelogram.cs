using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Parallelogram : Figure
    {
        private double sideA;
        private double sideB;

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Parallelogram():this (0.0, 0.0){}
        
        public Parallelogram(double sideA, double sideB)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            FigurePerimeter = 2 * (sideA + sideB);
        }
        public override string ToString()
        {
            return $"This is a parallelogram with sides: {sideA}, {sideB}.\n" + base.ToString();
        }
    }
}
