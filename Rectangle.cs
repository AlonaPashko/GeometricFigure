using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Rectangle : Figure, ISimplePolygon
    {
        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
        public double Height { get; set; }
        public double Basis { get; set; }
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Rectangle() : this(0.0, 0.0) { }
        
        public Rectangle(double height, double basis)
        {
            Height = height;
            Basis = basis;
            FigurePerimeter = PolygonPerimeter = 2 * (Height + Basis);
            FigureArea = PolygonArea = Height * Basis;
            AngBaseAndCloseSide = 90;
            SidesAmount = 4;
            SidesLength = new[] { Height, Basis, Height, Basis };
        }
        public override string ToString()
        {
            return $"This is a rectangle with sides: {Height}, {Basis}.\n" + base.ToString();
        }

        public string PrintSidesLength()
        {
            string sidesLength = "Sides Lehgth: ";
            for (int i = 0; i < SidesLength.Length; i++)
            {
                sidesLength += SidesLength[i].ToString() + " ";
            }
            return sidesLength;
        }
    }
}
