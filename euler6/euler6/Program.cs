using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler6
{
    class Program
    {
        /*
           The sum of the squares of the first ten natural numbers is,
            12 + 22 + ... + 102 = 385
            The square of the sum of the first ten natural numbers is,

            (1 + 2 + ... + 10)2 = 552 = 3025
            Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.

            Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
         */
        static void Main(string[] args)
        {
            int myN = -1;
            Console.WriteLine("Input number:");
            while (int.TryParse(Console.ReadLine(), out myN) == false)
            {
                Console.WriteLine("Incorrect input. Input number:");
            }
            Console.WriteLine(solve(myN).ToString());
            Console.ReadLine();
        }

        private static int solve(int myN)
        {
            int result = 0;
            int sumOfSquares = 0;
            int squareOfSums = 0;
            for (int i = 1; i <= myN; i++)
            {
                sumOfSquares += (int)Math.Pow((double)i, 2);
            }
            for (int i = 1; i <= myN; i++)
            {
                squareOfSums += i;
            }
            squareOfSums=(int)Math.Pow((double)squareOfSums , 2);

            result =squareOfSums- sumOfSquares;
            return result;
        }
    }
}
