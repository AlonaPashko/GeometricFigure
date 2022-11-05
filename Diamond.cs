using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Diamond : Figure
    {
        public double Side { get; set; }
        public double BigDiagonal { get; set; }
        public double SmallDiagonal { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }

        public Diamond():this(0.0, 0.0) { }
       
        public Diamond(double side, double bigDiagonal)
        {
            Side = side;
            BigDiagonal = bigDiagonal;
            SmallDiagonal = BigDiagonal / 2;
            FigurePerimeter = 4 * side;
            FigureArea = (BigDiagonal * SmallDiagonal) / 2;
        }
        public override string ToString()
        {
            return $"This is a diamond with sides: {Side}, big diagonal {BigDiagonal}" +
                $" and small diagonal {SmallDiagonal}.\n" 
                + base.ToString();
        }
    }
}
