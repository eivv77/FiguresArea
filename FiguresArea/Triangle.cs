using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea
{
    public class Triangle : Shape
    {
        public double xy { get; set; }
        public double yz { get; set; }
        public double xz { get; set; }

        public Triangle(string FigureName, double xy, double yz, double xz) : base(FigureName)
        {
            this.xy = xy;
            this.yz = yz;
            this.xz = xz;
        }

        public override double GetArea()
        {
            double miniP = (xy + yz + xz) / 2;
            double area = Math.Round(Math.Sqrt(miniP * (miniP - xy) * (miniP - yz) * (miniP - xz)), 2);

            return area;
        }

        public bool IsPramouqolniy()
        {
            bool x = (xy == Math.Sqrt(Math.Pow(yz, 2) + Math.Pow(xz, 2))
                   || yz == Math.Sqrt(Math.Pow(xy, 2) + Math.Pow(xz, 2))
                   || xz == Math.Sqrt(Math.Pow(xy, 2) + Math.Pow(yz, 2))
            );

            return x;
           
        }
    }
}
