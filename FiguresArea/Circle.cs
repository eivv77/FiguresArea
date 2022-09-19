using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea
{
    public class Circle : Shape
    {
        public double Radius { get; set; }

        public Circle(string FigureName, double radius) : base(FigureName)
        {
            Radius = radius;
        }

        public override double GetArea()
        {
            double square = (double)Math.Round(Math.PI * Math.Pow(Radius, 2), 1);
            return square;
        }
    }
}
