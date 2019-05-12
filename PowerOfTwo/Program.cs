using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerOfTwo
{
    /* Challenge: Create a method that determines if a given non-negative integer is a power of two.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.PowerOfTwo(7));
        }
    }

    public static class Kata
    {
        public static bool PowerOfTwo(int n)
        {
            if (n > 0)
            {
                while (n % 2 == 0)
                {
                    n = n / 2;
                }
                if (n == 1)
                {
                    return true;
                }
            }
            if (n == 0)
            {
                return false;
            }
            return false;
            
        }
    }
}