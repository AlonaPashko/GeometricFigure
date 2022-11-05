using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Disk : Figure
    {
        private double radius;

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Disk() : this(0.0) { }
        
        public Disk(double radius)
        {
            this.radius = radius;
        }
        public override string ToString()
        {
            return $"This is a disk with radius: {radius}.\n" + base.ToString();
        }
    }
}
