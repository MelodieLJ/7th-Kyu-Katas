using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_of_two_lowest_positive_ints
{
    //Challenge: Sum the two lowest positive integers
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public static class Kata
    {
        public static int sumTwoSmallestNumbers(int[] numbers)
        {
            int a = numbers[0];
            int b = numbers[1];

            if (b < a)
            {
                a = numbers[1];
                b = numbers[0];
            }

            for (int i = 2; i < numbers.Length; i++)
            {
                if (numbers[i] < a)
                {
                    a = numbers[i];
                    b = a;
                }
                else if (numbers[i] < b)
                {
                    b = numbers[i];
                }
            }

            return a + b;
        }
    }
}
