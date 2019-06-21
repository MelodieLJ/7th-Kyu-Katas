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
            Console.WriteLine(string.Join(", \n", Kata.OrderedCount("dayfiveofonehundreddaysofcode")));
        }
    }

    public class Kata
    {
        public static List<Tuple<char, int>> OrderedCount(string input)
        {
            //Create a Tuple list to store the result
            List<Tuple<char, int>> result = new List<Tuple<char, int>>();

            //Create a do/while loop whilst the string length is greater than 0
            do
            {
                //assign char variable to the first letter in the string argument
                char letter = input[0];
                int count = 0;

                //iterate through all the letters in the string
                for (int i = 0; i < input.Length; i++)
                {                  
                    if (input[i] == letter)
                    {
                        //if the letter at index of i is equal to the value stored in letter, increase the count and remove that letter from the string
                        count++;
                        input = input.Remove(i, 1);
                        //i-- is to ensure that the check is always done for the first letter in the string
                        i--;
                    }
                }
                result.Add(new Tuple<char, int>(letter, count));

            } while (input.Length > 0);
            return result;
        }
    }
}