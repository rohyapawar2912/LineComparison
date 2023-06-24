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
            Console.WriteLine("Welcome to Line Comparison!");

            // Create two lines
            Line line1 = new Line(2, 3, 5, 7);
            Line line2 = new Line(2, 3, 6, 9);

            // Compare the lines
            int comparisonResult = line1.CompareTo(line2);

            if (comparisonResult == 0)
            {
                Console.WriteLine("The lines are equal.");
            }
            else if (comparisonResult < 0)
            {
                Console.WriteLine("Line 1 is smaller than Line 2.");
            }
            else
            {
                Console.WriteLine("Line 1 is greater than Line 2.");
            }
        }
    }
}
