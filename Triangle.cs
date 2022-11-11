using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure.Exceptions;

namespace GeometricFigure
{
    internal class Triangle : Figure, ISimplePolygon
    {
        private double basis;
        private double sideA;
        private double sideB;
        private double height;

        public double HalfPerimeter { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Triangle() : this(0.0, 0.0, 0.0, 0.0) { }

        public Triangle(double inputBasis, double inputSideA, double inputSideB, double inputHeight)
        {

            this.basis = inputBasis;
            this.sideA = inputSideA;
            this.sideB = inputSideB;
            this.height = inputHeight;

            Basis = basis;
            SideA = sideA;
            SideB = sideB;
            Height = height;

            if ((Basis + SideA < SideB) || (Basis + SideB < SideA) || (SideA + SideB < Basis))
            {
               new ImpossibleFigureException();
            }

            FigurePerimeter = PolygonPerimeter = Basis + SideA + SideB;
            HalfPerimeter = FigurePerimeter / 2;
            FigureArea = PolygonArea = Math.Sqrt(HalfPerimeter * (HalfPerimeter - Basis) * (HalfPerimeter - SideA)
                * (HalfPerimeter - SideB));
            SidesAmount = 3;
            SidesLength = new[] { Basis, SideA, SideB };
        }
        public double Basis
        {
            get => basis;
            set { if (basis < 0) throw new NegativeSideException(); }
        }

        public double SideA
        {
            get => sideA;
            set { if (sideA < 0) throw new NegativeSideException(); }
        }

        public double SideB
        {
            get => sideB;
            set { if (sideB < 0) throw new NegativeSideException(); }
        }

        public double Height
        {
            get => height;
            set { if (height < 0) throw new NegativeSideException(); }
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
