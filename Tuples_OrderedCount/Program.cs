using System;
using System.Collections.Generic;

namespace Tuples_OrderedCount
{
    /* Count the number of occurrences of each character and return it as a list of tuples in order of appearance.
     */

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", \n", Kata.OrderedCount("dayoneofonehundreddaysofcode")));
        }
    }

    public class Kata
    {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            List<Tuple<char, int>> result = new List<Tuple<char, int>>();
            do
            {
                char letter = input[0];
                int count = 0;

                for (int i = 0; i < input.Length; i++)
                {
                    if (input[i] == letter)
                    {
                        count++;
                        input = input.Remove(i, 1);
                        i--;
                    }
                }
                result.Add(new Tuple<char, int>(letter, count));

            } while (input.Length > 0);
            return result;
        }
    }
}

