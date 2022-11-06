using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Parallelogram : Figure, ISimplePolygon
    {
        public double Side { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
        public double Height { get; set; }
        public double Basis { get; set; }
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Parallelogram():this (0.0, 0.0, 0.0){}
        
        public Parallelogram(double basis, double side, double height)
        {
            Basis = basis;
            Height = height;
            FigurePerimeter = PolygonPerimeter = 2 * (Basis + Side);
            FigureArea = PolygonArea = Basis * Height;
            SidesAmount = 4;
            SidesLength = new double[] { Basis, Side, Basis, Side };
        }
        public override string ToString()
        {
            return $"This is a parallelogram with sides: {Basis}, {Side} and height - {Height}.\n" 
                + base.ToString();
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
