using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticEx.Figures
{
    public class Circle: Figure
    {
        double radius;
        public Circle(double radius)
        {
            if (radius < 0) throw new ArgumentException("Радиус должен быть положительным");
            this.radius = radius;
        }

        public override double GetSquare()
        {
            return Math.PI * radius * radius;
        }
    }
}
