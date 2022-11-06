using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal interface ISimplePolygon
    {
        public double Height { get; set; }
        public double Basis { get; set; }
        public double AngBaseAndCloseSide { get; set; }
        public int SidesAmount { get; set; }
        public double[] SidesLength { get; set; }
        public double PolygonArea { get; set; }
        public double PolygonPerimeter { get; set; }

        public string PrintSidesLength();
       
    }
}
