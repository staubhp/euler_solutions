using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace euler4
{
    class Program
    {
        /*A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
          Find the largest palindrome made from the product of two 3-digit numbers.*/

        static void Main(string[] args)
        {
            Solver mySolver = new Solver();
            Console.WriteLine(mySolver.solveProblem4().ToString());
            Console.ReadLine();
        }
    }

    class Solver : ISolver
    {
        public bool isPalindrome(int i)
        {
            return i == i.reverse();
        }

        public int solveProblem4()
        {
            //brute force by multiplying 100-999. the other way would involve making palindromes until we found the biggest.
            int i = 999;
            int largest = 0;
            while (i >= 100)
            {
                int j = 999;
                while (j >= 100)
                {
                    int k = i * j;
                    if (isPalindrome(k) && k > largest) { largest = k; }
                    j--;
                }
                i--;
            }
            return largest;
        }

        
    }

    static class Extensions
    {
        public static int reverse(this int i)
        {
            int reversed = 0;
            while (i > 0)
            {
                reversed = reversed * 10 + i % 10;
                i = i / 10;
            }
            return reversed;
        }
    }

    interface ISolver
    {
        bool isPalindrome(int i);
        int solveProblem4();
    }
}
