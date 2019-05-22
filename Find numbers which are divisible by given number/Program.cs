using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_numbers_which_are_divisible_by_given_number
{
    /* Challenge: Create a function which takes two arguments and returns all numbers which are divisible by the given divisor. First argument is an array of numbers and the second is the divisor.
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(", ", Kata.DivisibleBy(new int[] { 1,2,3,4,5,6}, 2)));
        }
    }

    public static class Kata
    {
        public static int[] DivisibleBy(int[] numbers, int divisor)
        {
            //Create a new temporary List to store the numbers which are divisible by the divisor
            List<int> temp = new List<int>();

            //For loop to iterate through all the numbers in the array argument
            for (int i = 0; i < numbers.Length; i++)
            {
                //Check if the number in the array is divisible by the divisor
                if (numbers[i] % divisor == 0)
                {
                    //Add the divisible numbers to the new List
                    temp.Add(numbers[i]);
                }
            }
            //Return the new list as an Array
            return temp.ToArray();
        }
    }
}