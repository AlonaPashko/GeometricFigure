using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Triangle : Figure, ISimplePolygon
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double HalfPerimeter { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
        public double Height { get; set; }
        public double Basis { get; set; }
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Triangle() : this(0.0, 0.0, 0.0, 0.0) { }

        public Triangle(double basis, double sideA, double sideB, double height)
        {
            Basis = basis;
            SideA = sideA;
            SideB = sideB;
            Height = height;
            FigurePerimeter = PolygonPerimeter = Basis + SideA + SideB;
            HalfPerimeter = FigurePerimeter / 2;
            FigureArea = PolygonArea = Math.Sqrt(HalfPerimeter * (HalfPerimeter - Basis) * (HalfPerimeter - SideA) 
                * (HalfPerimeter - SideB));
            SidesAmount = 3;
            SidesLength = new[] { Basis, SideA, SideB };
        }
        
        public override string ToString()
        {
            return $"This is a triangle with sides: {Basis}, {SideA}, {SideB} and height: {Height}.\n" 
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
