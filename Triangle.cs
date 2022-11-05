﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class Triangle : Figure
    {
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        public double HalfPerimeter { get; set; }

        public override double FigureArea { get; set; }
        public override double FigurePerimeter { get; set; }
      
        public Triangle() : this(0.0, 0.0, 0.0) { }

        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
            FigurePerimeter = SideA + SideB + SideC;
            HalfPerimeter = FigurePerimeter / 2;
            FigureArea = Math.Sqrt(HalfPerimeter * (HalfPerimeter - SideA) * (HalfPerimeter - SideB) * (HalfPerimeter - SideC));
        }
        
        public override string ToString()
        {
            return $"This is a triangle with sides: {SideA}, {SideB}, {SideC}.\n" 
                + base.ToString();
        }
    }
}
