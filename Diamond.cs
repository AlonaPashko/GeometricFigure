using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure.Exceptions;

namespace GeometricFigure
{
    internal class Diamond : Figure, ISimplePolygon
    {
        private double basis;
        private double height;

        public double SmallDiagonal { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Diamond() : this(0.0, 0.0) { }

        public Diamond(double inputBasis, double inputHeight)
        {
            this.basis = inputBasis;
            this.height = inputHeight;
            Basis = basis;
            Height = height;
            SmallDiagonal = Height / 2;
            FigurePerimeter = PolygonPerimeter = 4 * Basis;
            FigureArea = PolygonArea = (Height * SmallDiagonal) / 2;
            SidesAmount = 4;
            SidesLength = new double[4] { Basis, Basis, Basis, Basis };
        }
        public double Basis
        {
            get
            {
                return basis;
            }
            set
            {
                if (basis < 0)
                {
                    throw new NegativeSideException();
                }
                basis = value;
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
            return $"This is a diamond with sides: {Basis}, big diagonal {Height}" +
                $" and small diagonal {SmallDiagonal}.\n"
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
