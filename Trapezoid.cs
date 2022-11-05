using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Trapezoid : Figure
    {
        public double BigSide { get; set; }
        public double SmallSide { get; set; }
        public double BigHeight { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Trapezoid():this (0.0, 0.0, 0.0) { }

        public Trapezoid(double bigSide, double smallSide, double height)
        {
            BigSide = bigSide;
            SmallSide = smallSide;
            BigHeight = height;
            FigurePerimeter = 2 * (BigSide + SmallSide);
            FigureArea = (BigSide + SmallSide) * BigHeight / 2;
            
        }

        public override string ToString()
        {
            return $"This is a trapezoid with big sides: {BigSide} and small sides: {SmallSide} and height: {BigHeight}.\n" 
                + base.ToString();
        }
    }
}
