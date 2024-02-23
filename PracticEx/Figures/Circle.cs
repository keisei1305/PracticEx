using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticEx.Figures
{
    class Circle: Figure
    {
        double radius;
        public Circle(double radius)
        {
            this.radius = radius;
        }

        public override double getSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}
