using System;
using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_With_Parameters
{
    class Program
    {
        static int addTwoNumbers(int num1, int num2)
        {
            int sum = num1 + num2;

            return sum;

        }


        static void Main(string[] args)
        {
            WriteLine("Enter two numbers: ");
            int toPass1 = Convert.ToInt32(ReadLine());
            int toPass2 = Convert.ToInt32(ReadLine());

            int result = addTwoNumbers(toPass1, toPass2);
            WriteLine("The result of " + toPass1 + " and " + toPass2 + " is: " + result + ".");

            ReadLine();
            
        }
    }
}
