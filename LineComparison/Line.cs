using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Line : IComparable<Line>
    {
        private double x1, y1, x2, y2;

        public Line(double x1, double y1, double x2, double y2)
        {
            this.x1 = x1;
            this.y1 = y1;
            this.x2 = x2;
            this.y2 = y2;
        }

        public int CompareTo(Line other)
        {
            if (other == null)
                throw new ArgumentNullException("other");

            double length1 = CalculateLength();
            double length2 = other.CalculateLength();

            return length1.CompareTo(length2);
        }

        private double CalculateLength()
        {
            double length = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return length;
        }
    }
}
