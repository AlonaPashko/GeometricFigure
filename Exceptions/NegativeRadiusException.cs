using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure.Exceptions
{
    internal class NegativeRadiusException : Exception
    {
        public NegativeRadiusException()
        {
            Console.WriteLine("Is a negative radius was entered");
            Console.ReadLine();
        }
    }
}
