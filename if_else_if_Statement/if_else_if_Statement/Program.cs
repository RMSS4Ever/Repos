using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_if_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare variables
            string comparison;

            // Get user input
            Console.WriteLine("Enter a number: ");
            double var1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            double var2 = Convert.ToDouble(Console.ReadLine());

            // Compare user inputs
            if (var1 < var2)
                comparison = "greater than";
            else if (var1 == var2)
            {
                comparison = "equal to";
            }
            else
            {
                comparison = "less than";
            }
            
            // Output comparison to screen
            Console.WriteLine($"The first number is {comparison} the second number.");

            // System pause
            Console.ReadLine();


        }
    }
}
