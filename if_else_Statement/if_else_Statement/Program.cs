﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace if_else_Statement
{
    class Program
    {
        static void Main(string[] args)
        {
            string comparison;

            Console.WriteLine("Enter a number: ");
            double var1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter a second number: ");
            double var2 = Convert.ToDouble(Console.ReadLine());

            // Compare the two variables
            if (var1 < var2)
                comparison = "less than";
            else
            {
                if (var1 == var2)
                    comparison = "equal to";
                else
                    comparison = "greater than";
            }

            // Output of Comparison
            Console.WriteLine($"The first number is {comparison} the second number.");

            // System pause
            Console.ReadLine();

        }
    }
}
