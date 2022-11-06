using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Trapezoid : Figure, ISimplePolygon
    {
        public double Side { get; set; }
        public double SmallBasis { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
        public double Height { get; set; }
        public double Basis { get; set; }
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Trapezoid():this (0.0, 0.0, 0.0, 0.0) { }

        public Trapezoid(double basis,double smallBasis, double side, double height)
        {
            Basis = basis;
            SmallBasis = smallBasis;
            Side = side;
            Height = height;
            FigurePerimeter = PolygonPerimeter = Basis + SmallBasis + 2 * Side;
            FigureArea = PolygonArea = (Basis + SmallBasis) * Height / 2;
            SidesAmount = 4;
            SidesLength = new[] { Basis, SmallBasis, Side, Side };
            
        }

        public override string ToString()
        {
            return $"This is a trapezoid with basis: {Basis}, small basis: {SmallBasis}, height: {Height} and" +
                $"sides: {Side}.\n" + base.ToString();
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
