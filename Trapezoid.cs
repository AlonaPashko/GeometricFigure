using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GeometricFigure.Exceptions;

namespace GeometricFigure
{
    internal class Trapezoid : Figure, ISimplePolygon
    {
        private double basis;
        private double smallBasis;
        private double side;
        private double height;

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
      
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Trapezoid():this (0.0, 0.0, 0.0, 0.0) { }

        public Trapezoid(double inputBasis,double inputSmallBasis, double inputSide, double inputHeight)
        {
            this.basis = inputBasis;
            this.smallBasis = inputSmallBasis;
            this.side = inputSide;
            this.height = inputHeight;
            
            Basis = basis;
            SmallBasis = smallBasis;
            Side = side;
            Height = height;
            
            FigurePerimeter = PolygonPerimeter = Basis + SmallBasis + 2 * Side;
            FigureArea = PolygonArea = (Basis + SmallBasis) * Height / 2;
            SidesAmount = 4;
            SidesLength = new[] { Basis, SmallBasis, Side, Side };
            
        }
        public double Basis { get => basis; 
            set { if (basis < 0) throw new NegativeSideException(); } }

        public double SmallBasis { get => smallBasis;
            set { if (smallBasis < 0) throw new NegativeSideException(); } }
        
        public double Side { get => side;
            set { if (side < 0) throw new NegativeSideException(); } }
        
        public double Height { get => height;
            set { if (height < 0) throw new NegativeSideException(); } }

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
