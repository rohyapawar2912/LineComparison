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
            Console.WriteLine("Welcome to Line Equality Check!");

            // Create two lines
            Line line1 = new Line(2, 3, 5, 7);
            Line line2 = new Line(2, 3, 5, 7);

            // Check if the lines are equal
            bool areEqual = line1.Equals(line2);

            if (areEqual)
            {
                Console.WriteLine("The lines are equal.");
            }
            else
            {
                Console.WriteLine("The lines are not equal.");
            }
        }
    }
}
