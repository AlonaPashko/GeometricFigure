using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure.Exceptions;

namespace GeometricFigure
{
    internal class Ellipse : Figure
    {
        private double bigRadius;
        private double smallRadius;

        public double BigRadius
        {
            get
            { return bigRadius; }
            set
            {
                if (bigRadius < 0)
                {
                    throw new NegativeRadiusException();
                }
                bigRadius = value;
            }
        }

        public double SmallRadius
        {
            get
            { return smallRadius; }
            set
            {
                if (smallRadius < 0)
                {
                    throw new NegativeRadiusException();
                }
                smallRadius = value;
            }
        }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Ellipse() : this(0.0, 0.0) { }

        public Ellipse(double inputBigRadius, double inputSmallRadius)
        {
            this.bigRadius = inputBigRadius;
            this.smallRadius = inputSmallRadius;
            BigRadius = bigRadius;
            SmallRadius = smallRadius;
            FigurePerimeter = 2 * Math.PI * Math.Sqrt((Math.Pow(BigRadius, 2) + Math.Pow(SmallRadius, 2)) / 2);
            FigureArea = Math.PI * BigRadius * SmallRadius;
        }
        public override string ToString()
        {
            return $"This is an ellipse with big radius - {BigRadius} and small radius - {SmallRadius}.\n"
                + base.ToString();
        }
    }
}
