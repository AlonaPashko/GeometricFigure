using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Diamond : Figure, ISimplePolygon
    {
        public double Side { get; set; }
        public double BigDiagonal { get; set; }
        public double SmallDiagonal { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
        public double Height { get; set; }
        public double Basis { get; set; }
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public Diamond():this(0.0, 0.0) { }
       
        public Diamond(double side, double bigDiagonal)
        {
            Side = Basis = side;
            BigDiagonal = Height = bigDiagonal;
            SmallDiagonal = BigDiagonal / 2;
            FigurePerimeter = PolygonPerimeter = 4 * side;
            FigureArea = PolygonArea = (BigDiagonal * SmallDiagonal) / 2;
            SidesAmount = 4;
            SidesLength = new double[4] {Side, Side, Side, Side};
        }
        public override string ToString()
        {
            return $"This is a diamond with sides: {Side}, big diagonal {BigDiagonal}" +
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
