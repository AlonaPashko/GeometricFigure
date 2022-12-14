using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure.Exceptions;

namespace GeometricFigure
{
    internal class Square : Figure, ISimplePolygon
    {
        private double basis;
        
        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
        public double Height { get; set; }
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Square(): this(0.0) { }
       
        public Square(double inputBasis)
        {
            this.basis = inputBasis;
            Height = Basis = basis;
            FigurePerimeter = PolygonPerimeter = 4 * Basis;
            FigureArea = PolygonArea = Math.Pow(Basis, 2);
            AngBaseAndCloseSide = 90;
            SidesAmount = 4;
            SidesLength = new[] { Basis, Basis, Basis, Basis };

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

        public override string ToString()
        {
            return $"This is a square with side: {Basis}.\n" + base.ToString();
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
