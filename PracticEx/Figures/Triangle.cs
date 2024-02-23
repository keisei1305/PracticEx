using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticEx.Figures
{
    public class Triangle : Figure
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
            if (!IsPossibleSides())
                throw new ArgumentException("Невозможные стороны");
        }

        public Triangle(double side1, double side2, double side3)
        {
            this.sides = new double[3];
            sides[0] = side1;
            sides[1] = side2;
            sides[2] = side3;
            if (!IsPossibleSides())
                throw new ArgumentException("Невозможные стороны");
        }

        public override double GetSquare()
        {
            double p = sides.Sum()/2;
            return Math.Sqrt(p * (p - sides[0]) * (p - sides[1]) * (p - sides[2]));
        }

        public bool IsRectangular()
        {
            double maxSide = sides.Max();
            double[] minSides = sides.Where(x => x < maxSide).ToArray();
            if (Math.Pow(maxSide, 2) - Math.Pow(minSides[0], 2) - Math.Pow(minSides[1], 2) < 0.001)
                return true;
            return false;
        }

        private bool IsPossibleSides()
        {
            double maxSide = sides.Max();
            double[] minSides = sides.Where(x => x < maxSide).ToArray();
            if (maxSide - minSides[0] - minSides[1] >= 0)
                return false;
            foreach(double side in sides)
            {
                if (side <= 0)
                    return false;
            }
            return true;
        }
    }
}
