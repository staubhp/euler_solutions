using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler5
{
    class Program
    {
        /* 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
         * What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
         */
        static void Main(string[] args)
        {
            Console.WriteLine(solve().ToString());
            Console.ReadLine();
        }

        private static int solve()
        {
            int result = 0;
           
            int i = 20;
            while (true)
            {
                bool found = true;
                for (int j = 20; j >= 3; j--)
                {
                    if ((i % j) > 0) 
                    {
                        found = false;
                        break;
                    }
                }
                if (found) { result = i; break; }
                i++;
            }
            return result;
        }
    }
}
