using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Line Calculation!");

            // Create two points
            double x1 = 2, y1 = 3;
            double x2 = 5, y2 = 7;

            // Create a line using the two points
            Line line = new Line(x1, y1, x2, y2);

            // Calculate and print the length of the line
            double length = line.CalculateLength();
            Console.WriteLine($"Length of the line: {length}");
        }
    }
}
