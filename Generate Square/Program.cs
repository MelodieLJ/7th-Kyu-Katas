using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generate_Square
{
    // Challenge: Given an int, return a square that is as long and as wide as the int
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Kata.GenerateSquare(3));
        }
    }

    public static class Kata
    {
        public static string GenerateSquare(int n)
        {
            //create a string array to store the square
            string[] result = new string[n];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    result[i] += "+";
                }
            }
            //separate each row by a space
            return string.Join("\n", result);
        }
    }
}
