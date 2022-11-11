using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometricFigure
{
    internal class ComposedFigure
    {
        public int NumberOfPolygons { get; set; }
        public List<Figure> Figures { get; set; }
        public double ComposedArea { get; set; }
        
        public ComposedFigure()
        {
            Figures = new List<Figure>();
            ComposedArea = 0;
        }
        public override string ToString()
        {
            return "Figure is composed of " + SetNumberOfPolygons().ToString() + " simple polygons:\n" + PrintTypes() 
                + "\n" + "The area of figure is " + Math.Round(ComposedArea, 3);
        }
    
        public double CountArea()
        {
            for (int i = 0; i < Figures.Count; i++)
            {
                ComposedArea += Figures[i].FigureArea;
            }
            return ComposedArea;
        }
        public int SetNumberOfPolygons()
        {
            NumberOfPolygons = Figures.Count;
            return NumberOfPolygons;
        }
        public string PrintTypes()
        {
            string types = "";
            for (int i = 0; i < Figures.Count; i++)
            {
                types += Figures[i].GetType().ToString() + "\n";
            }
            return types;
        }
    }
}
