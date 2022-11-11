using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure.Exceptions;

namespace GeometricFigure
{
    internal class Rectangle : Figure, ISimplePolygon
    {
        private double height;
        private double basis;
        
        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
       
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Rectangle() : this(0.0, 0.0) { }
        
        public Rectangle(double inputHeight, double inputBasis)
        {
            this.height = inputHeight;
            this.basis = inputBasis;
            Height = height;
            Basis = basis;
            FigurePerimeter = PolygonPerimeter = 2 * (Height + Basis);
            FigureArea = PolygonArea = Height * Basis;
            AngBaseAndCloseSide = 90;
            SidesAmount = 4;
            SidesLength = new[] { Height, Basis, Height, Basis };
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
