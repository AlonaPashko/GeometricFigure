using GeometricFigure.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Circle : Figure
    {
        private double radius;
        
        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Circle() : this(0.0) { }

        public Circle(double inputRadius)
        {
            this.radius = inputRadius;
            Radius = radius;
            FigurePerimeter = 2 * Math.PI * Radius;
            FigureArea = Math.PI * Math.Pow(Radius, 2);
        }
        public double Radius
        {
            get { return radius; }
            set
            {
                if (radius < 0)
                {
                    throw new NegativeRadiusException();
                }
                radius = value;
            }
        }
        public override string ToString()
        {
            return $"This is a circle with radius: {Radius}.\n" + base.ToString();
        }
    }
}
