using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Ellipse : Figure
    {
        public double BigRadius { get; set; }
        public double SmallRadius { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Ellipse() : this (0.0, 0.0) { }
        
        public Ellipse(double bigRadius, double smallRadius)
        {
            BigRadius = bigRadius;
            SmallRadius = smallRadius;
            FigurePerimeter = 2 * Math.PI * Math.Sqrt((Math.Pow(BigRadius, 2) + Math.Pow(SmallRadius, 2)) / 2);
        }
        public override string ToString()
        {
            return $"This is an ellipse with big radius - {BigRadius} and small radius - {SmallRadius}.\n" 
                + base.ToString();
        }
    }
}
