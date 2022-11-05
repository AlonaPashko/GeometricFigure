using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Triangle : Figure
    {
        private double sideA;
        private double sideB;
        private double sideC;

        public override double FigureArea { get; set; }

        public override double FigurePerimeter { get; set; }
      
        public Triangle() : this(0.0, 0.0, 0.0) { }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        
        public override string ToString()
        {
            return $"This is a triangle with sides: {sideA}, {sideB}, {sideC}.\n" + base.ToString();
        }
    }
}
