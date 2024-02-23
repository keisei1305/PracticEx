using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticEx.Figures
{
    class Triangle : Figure
    {
        double[] sides;
        public Triangle(IEnumerable<double> sides)
        {
            if (sides.Count() != 3) throw new ArgumentOutOfRangeException("Неверное количество сторон");
            int i = 0;
            this.sides = new double[3];
            foreach(double side in sides)
            {
                this.sides[i] = side;
            }
        }

        public Triangle(double side1, double side2, double side3)
        {
            sides[0] = side1;
            sides[1] = side2;
            sides[2] = side3;
        }

        public override double getSquare()
        {
            double p = sides.Sum()/2;
            return Math.Sqrt(p) * (p - sides[0]) * (p - sides[1]) * (p - sides[2]);
        }
    }
}
