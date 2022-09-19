using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FiguresArea
{
    public abstract class Shape
    {
        public string FigureName { get; set; }

        public Shape(string FigureName)
        {
            this.FigureName = FigureName;
        }

        public abstract double GetArea();
    }
}
