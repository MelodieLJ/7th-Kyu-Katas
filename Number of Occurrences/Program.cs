using System;

namespace Number_of_Occurrences
{
    //Challenge: Write a function that returns the number of occurrences of an element in an array.
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.NumberOfOccurrences(2, new int[] { 4,0,4}));
        }
    }

    public static class Kata
    {
        public static int NumberOfOccurrences(int x, int[] xs)
        {
            int count = 0;

            for (int i = 0; i < xs.Length; i++)
            {
                if (xs[i] == x)
                {
                    count++;
                }
            }

            return count;

            //return xs.Count(y => y == x)
            
        }
    }
}
