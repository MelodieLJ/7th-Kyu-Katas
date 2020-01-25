using System;

namespace Count_Divisors_of_a_Number
{
    //Challenge: Count the number of divisors of a positive integer n.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.Divisors(4));
        }
    }


    public static class Kata
    {
        public static int Divisors(int n)
        {
            //create an int variable for counting the number of divisors
            int count = 0;

            for (int i = 1; i <= n; i++)
            {
                //if n % by numbers starting from 1 != 0, then that number is Not a divisor
                if (n % i == 0)
                {
                    count++;
                }
            }
            return count;
        }
    }
}
