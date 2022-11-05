using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Disk : Figure
    {
        public double Radius { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Disk() : this(0.0) { }
        
        public Disk(double radius)
        {
            Radius = radius;
            FigurePerimeter = 2 * Math.PI * Radius;
        }
        public override string ToString()
        {
            return $"This is a disk with radius: {Radius}.\n" + base.ToString();
        }
    }
}
