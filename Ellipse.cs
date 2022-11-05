using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Ellipse : Figure
    {
        private double bigRadius;
        private double smallRadius;

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Ellipse() : this (0.0, 0.0) { }
        
        public Ellipse(double bigRadius, double smallRadius)
        {
            this.bigRadius = bigRadius;
            this.smallRadius = smallRadius;
        }
        public override string ToString()
        {
            return $"This is an ellipse with big radius - {bigRadius} and small radius - {smallRadius}.\n" 
                + base.ToString();
        }
    }
}
