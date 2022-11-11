using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure.Exceptions;

namespace GeometricFigure
{
    internal class Parallelogram : Figure, ISimplePolygon
    {
        private double basis;
        private double side;
        private double height;

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Parallelogram() : this(0.0, 0.0, 0.0) { }

        public Parallelogram(double inputBasis, double inputSide, double inputHeight)
        {
            this.basis = inputBasis;
            this.side = inputSide;
            this.height = inputHeight;
            Basis = basis;
            Side = side;
            Height = height;
            FigurePerimeter = PolygonPerimeter = 2 * (Basis + Side);
            FigureArea = PolygonArea = Basis * Height;
            SidesAmount = 4;
            SidesLength = new double[] { Basis, Side, Basis, Side };
        }
        public double Basis
        {
            get => basis;
            set
            {
                if (basis < 0)
                {
                    throw new NegativeSideException();
                }
                basis = value;
            }
        }

        public double Side
        {
            get => side;
            set
            {
                if (side < 0)
                {
                    throw new NegativeSideException();
                }
                side = value;
            }
        }
        public double Height
        {
            get => height;
            set
            {
                if (height < 0)
                {
                    throw new NegativeSideException();
                }
                height = value;
            }
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
