using System;

namespace Sum_of_multiples_of_3_and_5
{
    //Challenge: Write a function that will return the sum of all multiples of 3 and 5
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.FindSum(10));
        }
    }

    public static class Kata
    {
        public static int FindSum(int n)
        {
            int sum = 0;
            for (int i = 0; i <= n; i++)
            {
                if (i % 5 == 0 || i % 3 == 0)
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}