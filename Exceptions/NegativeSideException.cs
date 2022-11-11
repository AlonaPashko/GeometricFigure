using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure.Exceptions
{
    internal class NegativeSideException : Exception
    {
        public NegativeSideException()
        {
            Console.WriteLine("Is a negative side was entered");
            Console.ReadLine();
        }
    }
}
