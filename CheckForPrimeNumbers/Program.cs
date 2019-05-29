using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckForPrimeNumbers
{
    // Challenge: Define a function that takes an integer argument and returns logical value true or false depending on if the integer is a prime.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join("", Kata.IsPrime(19)));
        }
    }

    public static class Kata
    {
        public static bool IsPrime(int n)
        {
            if (n <= 1)
                return false;
            if (n == 2)
                return true;
            if (n % 2 == 0)
                return false;

            var x = (int)Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= x; i+=2)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }
    }
}
