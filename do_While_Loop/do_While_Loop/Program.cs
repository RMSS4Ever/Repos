using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace do_While_Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter an integer: ");

            int myInt = Convert.ToInt32(Console.ReadLine());

            // Variables
            bool isLessThan10 = myInt < 10;
            bool isBetween0And5 = (0 <= myInt) && (myInt <= 5);

            Console.WriteLine($"Integer less than 10? {isLessThan10}");
            Console.WriteLine($"Integer between 0 and 5? {isBetween0And5}");
            Console.WriteLine($"Exactly one of the above is true? {isLessThan10} + {isBetween0And5}");

            Console.ReadKey();

        
        }
    }
}
